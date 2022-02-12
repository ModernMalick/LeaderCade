using Firebase.Auth;
using FireBaseManager;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.GameCenter;

namespace Objects.FireBaseManager
{
    public class Login : MonoBehaviour
    {
        private string _authCode;

#if UNITY_IPHONE
        private void Awake()
        {
            IosLogin();
        }

        private void IosLogin()
        {
            Social.localUser.Authenticate(success =>
            {
                if (!success) return;
                FirebaseIosLogin();
            });
        }
        
        private void FirebaseIosLogin()
        {
            var auth = FirebaseAuth.DefaultInstance;
            var credential = GameCenterAuthProvider.GetCredentialAsync().Result;
            auth.SignInWithCredentialAsync(credential).ContinueWith(task =>
            {
                if (task.IsCanceled || task.IsFaulted) return;
                FirebaseManager.SetupFirebase();
            });
        }
#endif

#if UNITY_ANDROID
        private void Awake()
        {
            AndroidLogin();
        }

        private void AndroidLogin()
        {
            PlayGamesSetup();
            Social.localUser.Authenticate(success =>
            {
                if (!success) return;
                _authCode = PlayGamesPlatform.Instance.GetServerAuthCode();
                FirebaseAndroidLogin();
            });
        }

        private static void PlayGamesSetup()
        {
            var config = new PlayGamesClientConfiguration.Builder()
                .RequestServerAuthCode(false)
                .Build();
            PlayGamesPlatform.InitializeInstance(config);
            PlayGamesPlatform.Activate();
        }
        
        private void FirebaseAndroidLogin()
        {
            var auth = FirebaseAuth.DefaultInstance;
            var credential = PlayGamesAuthProvider.GetCredential(_authCode);
            auth.SignInWithCredentialAsync(credential).ContinueWith(task =>
            {
                if (task.IsCanceled || task.IsFaulted) return;
                FirebaseManager.SetupFirebase();
            });
        }
#endif
    }
}