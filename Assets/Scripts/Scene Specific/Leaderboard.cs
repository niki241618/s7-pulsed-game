using System.Linq;
using Players;
using TMPro;
using UnityEngine;

public class Leaderboard : MonoBehaviour
{
    [SerializeField] private GameObject playerScorePrefab;
    [SerializeField] private Transform leaderboardPanel;
    
    [SerializeField] private TMP_Text firstPlaceText;
    [SerializeField] private TMP_Text secondPlaceText;
    [SerializeField] private TMP_Text thirdPlaceText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var round = PlayersManager.Instance.CurrentRound;
        var players = round.Players.OrderByDescending(x => x.Score).ToList();

        for (int i = 0; i < players.Count; i++)
        {
            var playerScorePanel = Instantiate(playerScorePrefab, leaderboardPanel.transform);
            playerScorePanel.GetComponent<LeaderBoardPlayer>().SetPlayer(players[i], i + 1);

            switch (i)
            {
                case 0:
                    firstPlaceText.text = players[i].Name;
                    break;
                case 1:
                    secondPlaceText.text = players[i].Name;
                    break;
                case 2:
                    thirdPlaceText.text = players[i].Name;
                    break;
            }
        }
    }
}
