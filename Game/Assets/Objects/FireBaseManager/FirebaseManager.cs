using System;
using Firebase.Auth;
using Firebase.Database;
using Firebase.Extensions;
using Objects.UI.Menu.Main;
using UnityEngine;

namespace Objects.FireBaseManager
{
    public class FirebaseManager : MonoBehaviour
    {
        private static FirebaseUser User { get; set; }
        private static DatabaseReference Reference { get; set; }
        public static event Action Load;
        
        public static void SetupFirebase()
        {
            Debug.Log("Setup started");
            User = FirebaseAuth.DefaultInstance.CurrentUser;
            Reference = FirebaseDatabase.DefaultInstance.RootReference;
            CheckNewUser();
        }

        private static void CheckNewUser()
        {
            Reference.Child("Users").Child(User.UserId).GetValueAsync().ContinueWith(task =>
            {
                if (task.IsFaulted || task.IsCanceled) return;
                var snapshot = task.Result;
                if (snapshot.Exists)
                {
                    var highscore = int.Parse(snapshot.Child("Highscore").Value.ToString());
                    var totalscore = int.Parse(snapshot.Child("Totalscore").Value.ToString());
                    LoadScores(highscore, totalscore);
                    return;
                }
                WriteNewUser();
            });
        }

        private static void LoadScores(int highscore, int totalscore)
        {
            PlayerPrefs.SetInt("highscore", highscore); 
            PlayerPrefs.SetInt("totalscore", totalscore);
            Load?.Invoke();
        }

        private static void WriteNewUser()
        {
            Debug.Log("Connection of " + User.DisplayName);
            Reference.Child("Users").Child(User.UserId).Child("Nickname").SetValueAsync(User.DisplayName);
            UpdateHighScore();
            UpdateTotalScore();
            Debug.Log("Pushed " + User.UserId);
        }

        public static void UpdateHighScore()
        {
            var currentHigh = PlayerPrefs.GetInt("highscore", 0);
            Reference.Child("Users").Child(User.UserId).Child("Highscore").SetValueAsync(currentHigh);
        }

        public static void UpdateTotalScore()
        {
            var currentTotal = PlayerPrefs.GetInt("totalscore", 0);
            Reference.Child("Users").Child(User.UserId).Child("Totalscore").SetValueAsync(currentTotal);
        }

        public static void CreateTeam(String name)
        {
            Debug.Log("Creation of " + name + " for " + User.DisplayName);
            var key = Reference.Child("Teams").Push().Key;
            Reference.Child("Teams").Child(key).Child("Name").SetValueAsync(name);
            Reference.Child("Users").Child(User.UserId).Child("Team_ID").SetValueAsync(key);
        }
        
        public static void QuitTeam()
        {
            Debug.Log("Exit of " + User.DisplayName + " for " + User.DisplayName);
            Reference.Child("Users").Child(User.UserId).Child("Team_ID").SetValueAsync("");
        }
    }
}
