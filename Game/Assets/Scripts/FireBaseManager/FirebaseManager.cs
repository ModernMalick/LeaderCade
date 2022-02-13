using System;
using Firebase.Auth;
using Firebase.Database;
using Objects.UI.Leaderboard;
using UnityEngine;

namespace FireBaseManager
{
    public class FirebaseManager : MonoBehaviour
    {
        public static DatabaseReference Reference;
        public static FirebaseUser FbUser;
        public static event Action Load;
        public static bool Connected;

        private void Awake()
        {
            Reference = FirebaseDatabase.GetInstance("https://leadercade-a45d0-default-rtdb.firebaseio.com/").RootReference;
            FbUser = FirebaseAuth.DefaultInstance.CurrentUser;
        }

        public static void SetupFirebase()
        {
            UserManager.ReadUser();
            Connected = FbUser != null;
        }

        private static void OnLoad()
        {
            Load?.Invoke();
        }

        public static void LoadStats(int highscore)
        {
            PlayerPrefs.SetInt("highscore", highscore);
            OnLoad();
        }
    }
}