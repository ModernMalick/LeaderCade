using System;
using System.Collections;
using System.Collections.Generic;
using Firebase.Auth;
using UnityEngine;
using UnityEngine.Networking;

namespace FireBaseManager
{
    public class FirebaseManager : MonoBehaviour
    {
        public static User User = new User();
        public static Team Team = new Team();
        public static readonly FirebaseUser FbUser = FirebaseAuth.DefaultInstance.CurrentUser;
        public static event Action Load;
        public const string Php = "https://leadercade.000webhostapp.com/";

        public static void SetupFirebase()
        {
            StaticCoroutine.Start(User.ReadUser());
        }

        private static void OnLoad()
        {
            Load?.Invoke();
        }

        private static void LoadStats(int highscore, int totalscore)
        {
            PlayerPrefs.SetInt("highscore", highscore);
            PlayerPrefs.SetInt("totalscore", totalscore);
            OnLoad();
        }
    }
}