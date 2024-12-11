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
        [SerializeField] private TMP_Text currentRoundText;

        private SceneTransition sceneTransition;
        private PlayersManager playersManager;

        private void Start()
        {
            playersManager = PlayersManager.Instance;
            sceneTransition = GetComponent<SceneTransition>();

            // Test add players for debug

            playersManager.Players.Add(new Player("Nikolay"));
            playersManager.Players.Add(new Player("Stoyan"));
            playersManager.Players.Add(new Player("Martin"));
            playersManager.Players.Add(new Player("Yoanna"));

            // End test

            var round = playersManager.CurrentRound ??= new Round(playersManager.Players);
            
            if (round.IsOver)
            {
                if (round.RoundNumber + 1 >= (int)playersManager.GameLength)
                {
                    // End of the game. Yay
                    sceneTransition.ChangeScene("EndGameScene");
                    return;
                }

                var newRound = round.NewRound();
                
                playersManager.CurrentRound = newRound;
                round = newRound;
            }
            
            currentPlayerText.text = round.CurrentPlayer.Name;
            currentRoundText.text = $"Round {round.RoundNumber + 1}";
            fortuneWheel.OnSpinComplete?.AddListener(CategorySelected);
        }

        private void CategorySelected(Category category)
        {
            playersManager.CurrentRound.NewTurn(category);
            sceneTransition.ChangeScene("PlayerTurnScene");
        }
    }
}
