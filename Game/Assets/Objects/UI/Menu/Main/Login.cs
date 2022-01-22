using System;
using Firebase.Auth;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine;

namespace Objects.UI.Menu.Main
{
    public class Login : MonoBehaviour
    {
        private string _authCode;
        
        #if UNITY_IPHONE
            private void Start()
            {
                Debug.Log("STARTED IOS");
            }
        #endif

        #if UNITY_Android
                 private void Start()
        {
            AndroidLogin();
        }

        private void AndroidLogin()
        {
            PlayGamesSetup();
            Social.localUser.Authenticate((success) =>
            {
                if (!success) return;
                _authCode = PlayGamesPlatform.Instance.GetServerAuthCode();
            });
            FirebaseLogin();
        }

        private static void PlayGamesSetup()
        {
            var config = new PlayGamesClientConfiguration.Builder()
                .RequestServerAuthCode(false)
                .Build();

            PlayGamesPlatform.InitializeInstance(config);
            PlayGamesPlatform.Activate();
        }
        #endif

        private void FirebaseLogin()
        {
            var auth = FirebaseAuth.DefaultInstance;
            var credential = PlayGamesAuthProvider.GetCredential(_authCode);
            auth.SignInWithCredentialAsync(credential);
        }
    }
}