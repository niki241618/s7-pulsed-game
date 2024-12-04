using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayersHandler : MonoBehaviour
{
   public TMP_InputField playerNameInputField;
   
   public void CreatePlayer()
   {
      // Get the text from the Input Field
      string playerName = playerNameInputField.text; 

      if (!string.IsNullOrEmpty(playerName))
      {
         Debug.Log("Player created: " + playerName);
         playerNameInputField.text = string.Empty;
      }
   }

   public void DeletePlayer()
   {
      
   }
}
