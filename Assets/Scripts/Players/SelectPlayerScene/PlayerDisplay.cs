using Players;
using UnityEngine;

public class PlayerDisplay : MonoBehaviour
{
    public GameObject playerPrefab;
    
    [SerializeField] private PlayersHandler playersHandler;

    private void Start()
    {
        UpdatePlayerDisplay();
    }
    
    public void UpdatePlayerDisplay()
    {
        // Destroy all children of the container.
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
        
        // Instantiate a new player prefab for each player in the list.

        var playersManager = PlayersManager.Instance;
        
        foreach (var player in playersManager.Players)
        {
            var playerObject = Instantiate(playerPrefab, transform);
            var playerInfo = playerObject.GetComponent<PlayerInfo>();
            playerInfo.SetPlayer(player);
            playerInfo.deleteButton.onClick.AddListener(() => playersHandler.DeletePlayer(player.Id));
        }
    }
}
