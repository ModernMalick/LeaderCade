using System;
using System.Text;
using AppleAuth;
using AppleAuth.Enums;
using AppleAuth.Extensions;
using AppleAuth.Interfaces;
using AppleAuth.Native;
using Firebase.Auth;
using UnityEngine;

namespace FireBaseManager
{
    public class Login : MonoBehaviour
    {
        private string _authCode;
        private IAppleAuthManager _appleAuthManager;

#if UNITY_IPHONE
        private void Awake()
        {
            IosLogin();
        }

        private void Update()
        {
            _appleAuthManager?.Update();
        }

        private void IosLogin()
        {
            AppleSignInSetup();
            
            var rawNonce = GenerateRandomString.Generator(32);
            var nonce = GenerateRandomString.GenerateSHA256NonceFromRawNonce(rawNonce);
            
            var loginArgs = new AppleAuthLoginArgs(LoginOptions.IncludeEmail | LoginOptions.IncludeFullName, nonce);
            
            var quickLoginArgs = new AppleAuthQuickLoginArgs();

            _appleAuthManager.QuickLogin(
                quickLoginArgs,
                credential =>
                {
                    // Received a valid credential!
                    // Try casting to IAppleIDCredential or IPasswordCredential

                    // Previous Apple sign in credential
                    var appleIdCredential = credential as IAppleIDCredential; 

                    // Saved Keychain credential (read about Keychain Items)
                    var passwordCredential = credential as IPasswordCredential;
                },
                error =>
                {
                    // Quick login failed. The user has never used Sign in With Apple on your app. Go to login screen
                    initialLogin(loginArgs, rawNonce);
                });
        }

        private void initialLogin(AppleAuthLoginArgs loginArgs, string rawNonce)
        {
            _appleAuthManager.LoginWithAppleId(
                loginArgs,
                credential =>
                {
                    // Obtained credential, cast it to IAppleIDCredential
                    var appleIdCredential = credential as IAppleIDCredential;
                    if (appleIdCredential == null) return;
                    // Apple User ID
                    // You should save the user ID somewhere in the device
                    var userId = appleIdCredential.User;
                    PlayerPrefs.SetString("AppleUserIdKey", userId);

                    // Email (Received ONLY in the first login)
                    var email = appleIdCredential.Email;

                    // Full name (Received ONLY in the first login)
                    var fullName = appleIdCredential.FullName;

                    // Identity token
                    var identityToken = Encoding.UTF8.GetString(
                        appleIdCredential.IdentityToken,
                        0,
                        appleIdCredential.IdentityToken.Length);

                    // Authorization code
                    var authorizationCode = Encoding.UTF8.GetString(
                        appleIdCredential.AuthorizationCode,
                        0,
                        appleIdCredential.AuthorizationCode.Length);

                    // And now you have all the information to create/login a user in your system

                    FirebaseIosLogin(identityToken, rawNonce);
                },
                error =>
                {
                    // Something went wrong
                    var authorizationErrorCode = error.GetAuthorizationErrorCode();
                });
        }

        private void AppleSignInSetup()
        {
            // Creates a default JSON deserializer, to transform JSON Native responses to C# instances
            var deserializer = new PayloadDeserializer();
            // Creates an Apple Authentication manager with the deserializer
            _appleAuthManager = new AppleAuthManager(deserializer);    
        }
        
        private void FirebaseIosLogin(string appleIdToken, string rawNonce)
        {
            var credential = OAuthProvider.GetCredential("apple.com", appleIdToken, rawNonce, null);
            FirebaseAuth.DefaultInstance.SignInWithCredentialAsync(credential).ContinueWith(task => {
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