using System;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine;

namespace Objects.UI.Menu.Main
{
    public class Login : MonoBehaviour
    {
        private void Start()
        {
            var config = new PlayGamesClientConfiguration.Builder()
                .RequestServerAuthCode(false)
                .Build();

            PlayGamesPlatform.InitializeInstance(config);
            PlayGamesPlatform.Activate();
        }

        public void AndroidLogin()
        {
            Social.localUser.Authenticate((bool success) => {
                Debug.Log("Connection success = " + success);
            });
        }
    }
}
