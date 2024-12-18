using Players;
using TMPro;
using UnityEngine;

public class LeaderBoardPlayer : MonoBehaviour
{
    [SerializeField] private TMP_Text playerNameText;
    [SerializeField] private TMP_Text playerScoreText;
    [SerializeField] private TMP_Text positionText;

    public void SetPlayer(Player player, int position)
    {
        playerNameText.text = player.Name;
        playerScoreText.text = player.Score.ToString();
        positionText.text = position.ToString();
    }
}
