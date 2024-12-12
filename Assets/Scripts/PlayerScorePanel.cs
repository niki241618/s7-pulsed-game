using Players;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScorePanel : MonoBehaviour
{
    [SerializeField] private TMP_Text playerNameText;
    [SerializeField] private TMP_Text playerScoreText;
    [SerializeField] private Image backgroundImage;
    
    public void SetPlayer(Player player)
    {
        playerNameText.text = player.Name;
        playerScoreText.text = player.Score.ToString();
    }
}
