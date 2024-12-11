using System;
using Players;
using UnityEngine;

namespace GameScripts
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private FortuneWheel fortuneWheel;
        private PlayersManager playersManager;

        private void Start()
        {
            playersManager = PlayersManager.Instance;
            fortuneWheel.OnSpinComplete?.AddListener(StartGame);
        }

        private void StartGame()
        {
            Debug.Log("Starting the game... Category: " + playersManager.CurrentCategory);
        }
    }
}
