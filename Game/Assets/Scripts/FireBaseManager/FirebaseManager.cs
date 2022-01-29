using System;
using Firebase.Auth;
using Firebase.Database;
using UnityEngine;

namespace FireBaseManager
{
    public class FirebaseManager : MonoBehaviour
    {
        public static readonly DatabaseReference Reference = FirebaseDatabase.DefaultInstance.RootReference;
        public static readonly FirebaseUser FbUser = FirebaseAuth.DefaultInstance.CurrentUser;
        public static User User;
        public static event Action Load;

        public static void SetupFirebase()
        {
            UserManager.CreateUser();
        }

        private static void OnLoad()
        {
            Load?.Invoke();
        }

        private static void LoadStats(int highscore)
        {
            PlayerPrefs.SetInt("highscore", highscore);
            OnLoad();
        }
    }
}