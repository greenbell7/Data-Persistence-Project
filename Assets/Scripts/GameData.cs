using System;
using System.Collections.Generic;

[Serializable]
public class GameData
{
    public List<PlayerScore> leaderboard = new List<PlayerScore>();
}

[Serializable]
public class PlayerScore
{
    public string playerName;
    public int score;

    public PlayerScore(string name, int score)
    {
        playerName = name;
        this.score = score;
    }
}

