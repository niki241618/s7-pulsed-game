using Players;
using TMPro;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] private TMP_Text playerNameText;
    
    public Player Player { get; private set; }

    public void SetPlayer(Player player)
    {
        this.Player = player;
        playerNameText.text = player.Name;
    }
}
