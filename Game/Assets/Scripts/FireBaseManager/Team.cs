using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

namespace FireBaseManager
{
    public class Team
    {
        public Team(int id = default, string name = null)
        {
            ID = id;
            Name = name;
        }

        private int ID { get; set; }
        private string Name { get; set; }
        
        private static IEnumerator CreateTeam(string name)
        {
            var form = new WWWForm();
            form.AddField("new_team", "true");
            form.AddField("name", name);

            var www = UnityWebRequest.Post(FirebaseManager.Php, form);
            yield return www.SendWebRequest();
        }
        
        public static IEnumerator ReadTeam()
        {
            var form = new WWWForm();
            form.AddField("get_team", "true");
            form.AddField("team_id", FirebaseManager.User.TeamID);
            
            var www = UnityWebRequest.Post(FirebaseManager.Php, form);
            yield return www.SendWebRequest();
            
            var result = www.downloadHandler.text;

            if (www.downloadHandler.text.Equals("")) yield break;
            
            var parsedResult = result.Split('|');
            FirebaseManager.Team.ID = int.Parse(parsedResult[0]);
            FirebaseManager.Team.Name = parsedResult[1];
        }
        
        public IEnumerator UpdateName(string name)
        {
            var form = new WWWForm();
            form.AddField("new_name", name);
            form.AddField("team_id", FirebaseManager.Team.ID);

            var www = UnityWebRequest.Post(FirebaseManager.Php, form);
            yield return www.SendWebRequest();
        }
    }
}