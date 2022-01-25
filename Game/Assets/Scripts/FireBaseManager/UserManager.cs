using Firebase.Database;
using UnityEngine;

namespace FireBaseManager
{
    public class UserManager : MonoBehaviour
    {
        public static DatabaseReference ReferenceUser()
        {
            return FirebaseManager.Reference.Child("Users").Child(FirebaseManager.User.UserId);
        }

        private static void CreateUser()
        {
            ReferenceUser().Child("Nickname").SetValueAsync(FirebaseManager.User.DisplayName);
            UpdateHighScore();
            UpdateTotalScore();
        }

        public static void GetUser()
        {
            ReferenceUser().GetValueAsync().ContinueWith(
                task =>
                {
                    if (task.IsFaulted || task.IsCanceled) return;
                    var snapshot = task.Result;
                    if (snapshot.Exists)
                    {
                        var highscore = int.Parse(snapshot.Child("Highscore").Value.ToString());
                        var totalscore = int.Parse(snapshot.Child("Totalscore").Value.ToString());
                        LoadStats(highscore, totalscore);
                        return;
                    }
                    CreateUser();
                });
        }
        
        public static string GetTeam()
        {
            return ReferenceUser().Child("Team_ID").GetValueAsync().Result.Value.ToString();
        }
        
        private static void LoadStats(int highscore, int totalscore)
        {
            PlayerPrefs.SetInt("highscore", highscore);
            PlayerPrefs.SetInt("totalscore", totalscore);
            FirebaseManager.OnLoad();
        }

        public static void UpdateHighScore()
        {
            var currentHigh = PlayerPrefs.GetInt("highscore", 0);
            ReferenceUser().Child("Highscore").SetValueAsync(currentHigh);
        }

        public static void UpdateTotalScore()
        {
            var currentTotal = PlayerPrefs.GetInt("totalscore", 0);
            ReferenceUser().Child("Totalscore").SetValueAsync(currentTotal);
        }

        public static void UpdateTeam(string teamID)
        {
            teamID ??= "";
            ReferenceUser().Child("Team_ID").SetValueAsync(teamID);
        }
    }
}