using System;
using Players;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayersHandler : MonoBehaviour
{
   private const int MaxPeople = 10;
   
   [SerializeField]
   private TMP_InputField playerNameInputField;

   [SerializeField] private Button startButton;
   
   [SerializeField]
   private PlayerDisplay playerDisplay;
   private PlayersManager playersManager;

   private GameObject playerCreator;
   private void Start()
   {
      playersManager = PlayersManager.Instance;
      playerCreator = this.gameObject;
   }

   public void CreatePlayer()
   {
      // Get the text from the Input Field
      string playerName = playerNameInputField.text; 

      if (!string.IsNullOrEmpty(playerName) && playersManager.Players.Count < MaxPeople)
      {
         var player = new Player(playerName);
         playersManager.Players.Add(player);
         playerNameInputField.text = string.Empty;
      }

      if (playersManager.Players.Count > 0)
      {
         startButton.interactable = true;
      }

      if (playersManager.Players.Count >= MaxPeople)
      {
         playerCreator.SetActive(false);
      }
      
      playerDisplay.UpdatePlayerDisplay();
   }

   public void DeletePlayer(Guid id)
   {
      playersManager.Players.RemoveAll(player => player.Id == id);
      playerDisplay.UpdatePlayerDisplay();
      
      if(playersManager.Players.Count < MaxPeople)
      {
         playerCreator.SetActive(true);
      }
      
      if (playersManager.Players.Count < 1)
      {
         startButton.interactable = false;
      }
   }
}
