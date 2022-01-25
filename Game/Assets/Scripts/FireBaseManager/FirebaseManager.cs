using System;
using Firebase.Auth;
using Firebase.Database;
using UnityEngine;

namespace FireBaseManager
{
    public class FirebaseManager : MonoBehaviour
    {
        public static FirebaseUser User { get; private set; }
        public static DatabaseReference Reference { get; private set; }
        public static event Action Load;

        public static void SetupFirebase()
        {
            User = FirebaseAuth.DefaultInstance.CurrentUser;
            Reference = FirebaseDatabase.DefaultInstance.RootReference;
            UserManager.GetUser();
            Debug.Log("Returned & team is " + UserManager.GetTeam());
            Debug.Log("Returned & team users are " + TeamManager.GetTeamUserCount());
        }

        public static void OnLoad()
        {
            Load?.Invoke();
        }

        public static void CreateTeam(string name)
        {
            var key = Reference.Child("Teams").Push().Key;
            UserManager.UpdateTeam(key);
            TeamManager.CreateTeam(key, name);
        }
    }
}