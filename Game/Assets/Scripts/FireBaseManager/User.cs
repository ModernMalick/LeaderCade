using System;
using UnityEngine;

namespace FireBaseManager
{
    public class User
    {
        public User(String id, string nickname = null, int highscore = default)
        {
            Id = id;
            Nickname = nickname;
            Highscore = highscore;
        }
        private string Id { get; set; }
        
        private string Nickname { get; set; }

        private int Highscore { get; set; }
    }
}