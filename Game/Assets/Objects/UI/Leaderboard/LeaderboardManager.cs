using System.Collections.Generic;
using System.Linq;
using Firebase.Database;
using Firebase.Extensions;
using FireBaseManager;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Objects.UI.Leaderboard
{
    public class LeaderboardManager : MonoBehaviour
    {
        [SerializeField] private GameObject row;
        private static GameObject _prefab;
        private static GameObject _gameObject;
        
        private void Awake()
        {
            _prefab = row;
            _gameObject = gameObject;
        }

        public static void InstantiateRows()
        {
            if (!FirebaseManager.Connected)
            {
                var newRow = Instantiate(_prefab, new Vector3 (0,0,0), Quaternion.identity,
                    _gameObject.transform);
                newRow.transform.localScale = new Vector3(1, 1, 1);
                var rowText = newRow.GetComponent<TextMeshProUGUI>();
                rowText.text = "#" + 0 + " YOU " + ScoreManager.Instance.HighScore.ToString("0");
                return;
            }
            
            FirebaseManager.Reference.Child("Users").OrderByChild("Highscore").GetValueAsync().ContinueWithOnMainThread(task =>
            {
                if (task.IsFaulted || task.IsCanceled) return;
                var snapshot = task.Result;
                if (!snapshot.Exists) return;
                var rank = 0;
                foreach (var child in snapshot.Children.Reverse())
                {
                    rank++;
                    var nickname = child.Child("Nickname").Value.ToString();
                    var highscore = int.Parse(child.Child("Highscore").Value.ToString());
                    var newRow = Instantiate(_prefab, new Vector3 (0,0,0), Quaternion.identity,
                        _gameObject.transform);
                    newRow.transform.localScale = new Vector3(1, 1, 1);
                    var rowText = newRow.GetComponent<TextMeshProUGUI>();
                    rowText.text = "#" + rank + " " + nickname + " " + highscore;
                }
            });
        }
    }
}
