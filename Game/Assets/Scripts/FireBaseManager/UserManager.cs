using Firebase.Database;
using UnityEngine;

namespace FireBaseManager
{
    public class UserManager : MonoBehaviour
    {
        private static DatabaseReference ReferenceUser()
        {
            return FirebaseManager.Reference.Child("Users").Child(FirebaseManager.FbUser.UserId);
        }

        private static void CreateUser()
        {
            var displayName =  FirebaseManager.FbUser.DisplayName;
            ReferenceUser().Child("Nickname").SetValueAsync(displayName);
            UpdateHighScore();
            ReadUser();
        }
        
        public static void ReadUser()
        {
            ReferenceUser().GetValueAsync().ContinueWith(
                task =>
                {
                    if (task.IsFaulted || task.IsCanceled) return;
                    var snapshot = task.Result;
                    if (snapshot.Exists)
                    {
                        var highscore = int.Parse(snapshot.Child("Highscore").Value.ToString());
                        FirebaseManager.LoadStats(highscore);
                        return;
                    }
                    CreateUser();
        });
        }

        public static void UpdateHighScore()
        {
            var currentHigh = PlayerPrefs.GetInt("highscore", 0);
            ReferenceUser().Child("Highscore").SetValueAsync(currentHigh);
        }
    }
}