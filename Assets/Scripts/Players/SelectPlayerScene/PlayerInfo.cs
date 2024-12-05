using Players;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] private TMP_Text playerNameText;
    [FormerlySerializedAs("button")] public Button deleteButton;
    public Player Player { get; private set; }

    public void SetPlayer(Player player)
    {
        this.Player = player;
        playerNameText.text = player.Name;
    }
}
