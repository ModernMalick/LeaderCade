using UnityEngine;

namespace FireBaseManager
{
    public class UserManager : MonoBehaviour
    {
        public static void CreateUser()
        {
            var currentHigh = PlayerPrefs.GetInt("highscore", 0);
            var fbuser = FirebaseManager.FbUser;
            var displayName = fbuser.DisplayName;
            var id = fbuser.UserId;
            var user = new User(id,displayName,0);
            var json = JsonUtility.ToJson(user);
            FirebaseManager.Reference.Child("users").Child(id).SetRawJsonValueAsync(json);
        }
        
        public static void ReadUser()
        {
            
        }

        public static void UpdateHighScore()
        {
            var currentHigh = PlayerPrefs.GetInt("highscore", 0);
        }
    }
}