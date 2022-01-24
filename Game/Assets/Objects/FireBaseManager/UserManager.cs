using UnityEngine;

namespace Objects.FireBaseManager
{
    public class UserManager : MonoBehaviour
    {
        private static void CreateUser()
        {
            FirebaseManager.Reference.Child("Users").Child(FirebaseManager.User.UserId).Child("Nickname")
                .SetValueAsync(FirebaseManager.User.DisplayName);
            UpdateHighScore();
            UpdateTotalScore();
        }

        public static void GetUser()
        {
            FirebaseManager.Reference.Child("Users").Child(FirebaseManager.User.UserId).GetValueAsync().ContinueWith(
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
        
        private static void LoadStats(int highscore, int totalscore)
        {
            PlayerPrefs.SetInt("highscore", highscore);
            PlayerPrefs.SetInt("totalscore", totalscore);
            FirebaseManager.OnLoad();
        }

        public static void UpdateHighScore()
        {
            var currentHigh = PlayerPrefs.GetInt("highscore", 0);
            FirebaseManager.Reference.Child("Users").Child(FirebaseManager.User.UserId).Child("Highscore")
                .SetValueAsync(currentHigh);
        }

        public static void UpdateTotalScore()
        {
            var currentTotal = PlayerPrefs.GetInt("totalscore", 0);
            FirebaseManager.Reference.Child("Users").Child(FirebaseManager.User.UserId).Child("Totalscore")
                .SetValueAsync(currentTotal);
        }

        public static void UpdateTeam(string teamID)
        {
            teamID ??= "";
            FirebaseManager.Reference.Child("Users").Child(FirebaseManager.User.UserId).Child("Team_ID")
                .SetValueAsync(teamID);
        }
    }
}