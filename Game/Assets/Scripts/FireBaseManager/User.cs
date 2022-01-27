using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

namespace FireBaseManager
{
    public class User
    {
        public User(int id = default, string nickname = null, int highscore = default, int totalscore = default, int teamID = default)
        {
            ID = id;
            Nickname = nickname;
            Highscore = highscore;
            Totalscore = totalscore;
            TeamID = teamID;
        }

        private int ID { get; set; }

        private string Nickname { get; set; }

        private int Highscore { get; set; }

        private int Totalscore { get; set; }

        public int TeamID;

        private static IEnumerator CreateUser()
        {
            var form = new WWWForm();
            form.AddField("new_user", "true");
            form.AddField("nickname", FirebaseManager.FbUser.DisplayName);

            var www = UnityWebRequest.Post(FirebaseManager.Php, form);
            yield return www.SendWebRequest();

            StaticCoroutine.Start(ReadUser());
        }
        
        public static IEnumerator ReadUser()
        {
            var form = new WWWForm();
            form.AddField("get_user", "true");
            form.AddField("nickname", FirebaseManager.FbUser.DisplayName);
            
            var www = UnityWebRequest.Post(FirebaseManager.Php, form);
            yield return www.SendWebRequest();
            
            var result = www.downloadHandler.text;

            if (www.downloadHandler.text.Equals(""))
            {
                StaticCoroutine.Start(CreateUser());
            }
            else
            {
                var parsedResult = result.Split('|');
                FirebaseManager.User.ID = int.Parse(parsedResult[0]);
                FirebaseManager.User.Nickname = parsedResult[1];
                FirebaseManager.User.Highscore = int.Parse(parsedResult[2]);
                FirebaseManager.User.Totalscore = int.Parse(parsedResult[3]);
                FirebaseManager.User.TeamID = parsedResult[4] != "" ? int.Parse(parsedResult[4]) : 0;
            }
        }

        public static IEnumerator UpdateHighScore()
        {
            var currentHigh = PlayerPrefs.GetInt("highscore", 0);
            FirebaseManager.User.Highscore = currentHigh;
            
            var form = new WWWForm();
            form.AddField("new_highscore", currentHigh);
            form.AddField("user_id", FirebaseManager.User.ID);

            var www = UnityWebRequest.Post(FirebaseManager.Php, form);
            yield return www.SendWebRequest();
        }

        public static IEnumerator UpdateTotalScore()
        {
            var currentTotal = PlayerPrefs.GetInt("totalscore", 0);
            FirebaseManager.User.Totalscore = currentTotal;
            
            var form = new WWWForm();
            form.AddField("new_totalscore", currentTotal);
            form.AddField("user_id", FirebaseManager.User.ID);

            var www = UnityWebRequest.Post(FirebaseManager.Php, form);
            yield return www.SendWebRequest();
        }
        
        public IEnumerator UpdateTeamID(int team_id)
        {
            FirebaseManager.User.TeamID = team_id;
            
            var form = new WWWForm();
            form.AddField("new_teamid", team_id);
            form.AddField("user_id", FirebaseManager.User.ID);

            var www = UnityWebRequest.Post(FirebaseManager.Php, form);
            yield return www.SendWebRequest();
        }
    }
}