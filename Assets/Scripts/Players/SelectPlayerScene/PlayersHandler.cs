using System;
using Players;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayersHandler : MonoBehaviour
{
   [SerializeField]
   private TMP_InputField playerNameInputField;
   
   [SerializeField]
   private PlayerDisplay playerDisplay;
   private readonly PlayersManager playersManager = PlayersManager.Instance;

   private GameObject playerCreator;
   private void Start()
   {
      playerCreator = this.gameObject;
   }

   public void CreatePlayer()
   {
      // Get the text from the Input Field
      string playerName = playerNameInputField.text; 

      if (playersManager.Players.Count + 1 > 10)
      {
         // Hide the player creator.
         return;
      }

      if (!string.IsNullOrEmpty(playerName))
      {
         var player = new Player(playerName);
         playersManager.Players.Add(player);
         playerNameInputField.text = string.Empty;
      }
      
      playerDisplay.UpdatePlayerDisplay();
   }

   public void DeletePlayer(Guid id)
   {
      playersManager.Players.RemoveAll(player => player.Id == id);
      playerDisplay.UpdatePlayerDisplay();
   }
}
