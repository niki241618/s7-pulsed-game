using System.Linq;
using GameScripts;
using Players;
using UnityEngine;

public class LeaderboardSmall : MonoBehaviour
{
    [SerializeField] private GameObject playerScorePrefab;
    [SerializeField] private GameObject leaderboardPanel;
    
    private Round round;
    void Start()
    {
        round = PlayersManager.Instance.CurrentRound;
        
        foreach (var player in round.Players.OrderByDescending(x => x.Score).Take(3))
        {
            var playerScorePanel = Instantiate(playerScorePrefab, leaderboardPanel.transform);
            playerScorePanel.GetComponent<PlayerScorePanel>().SetPlayer(player);
        }
    }
}
