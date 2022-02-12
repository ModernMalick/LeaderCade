using System;

namespace FireBaseManager
{
    public class LeaderboardRow
    {
        public LeaderboardRow(int rank, string nickname, int highscore)
        {
            Rank = rank;
            Nickname = nickname;
            Highscore = highscore;
        }

        public int Rank { get; }

        public string Nickname { get; }

        public int Highscore { get; }
    }
}