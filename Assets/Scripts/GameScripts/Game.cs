using System;
using Players;
using TMPro;
using UnityEngine;

namespace GameScripts
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private FortuneWheel fortuneWheel;
        [SerializeField] private TMP_Text currentPlayerText;

        private SceneTransition sceneTransition;
        
        private PlayersManager playersManager;
        private Round round = new();

        private void Start()
        {
            playersManager = PlayersManager.Instance;
            sceneTransition = GetComponent<SceneTransition>();
            
            playersManager.CurrentRound = round;
            // Test add players for debug
            
            playersManager.Players.Add(new Player("Nikolay"));
            playersManager.Players.Add(new Player("Stoyan"));
            playersManager.Players.Add(new Player("Martin"));
            playersManager.Players.Add(new Player("Yoanna"));
            
            // End test
            
            round.Players = playersManager.Players.ToArray();
            currentPlayerText.text = round.CurrentPlayer.Name;
            fortuneWheel.OnSpinComplete?.AddListener(CategorySelected);
        }

        private void CategorySelected(Category category)
        {
            Debug.Log(category);
            round.NewTurn(category);
            sceneTransition.ChangeScene("PlayerTurnScene");
        }
    }
}
