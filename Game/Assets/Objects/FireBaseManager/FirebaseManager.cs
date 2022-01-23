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
            Reference.Child("users").Child(User.DisplayName).GetValueAsync().ContinueWith(task =>
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
            var highscore = PlayerPrefs.GetInt("highscore", 0); 
            var totalscore = PlayerPrefs.GetInt("totalscore", 0);
            var user = new User(highscore, totalscore);
            var json = JsonUtility.ToJson(user);
            Reference.Child("users").Child(User.DisplayName).SetRawJsonValueAsync(json);
            Debug.Log("Pushed " + User.UserId);
        }

        public static void UpdateHighScore(int highscore)
        {
            Reference.Child("users").Child(User.DisplayName).Child("Highscore").SetValueAsync(highscore);
        }

        public static void UpdateTotalScore()
        {
            var currentTotal = PlayerPrefs.GetInt("totalscore", 0);
            Reference.Child("users").Child(User.DisplayName).Child("Totalscore").SetValueAsync(currentTotal);
        }
    }
}
