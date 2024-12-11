using System.Collections.Generic;
using GameScripts;
using UnityEngine;

namespace Players
{
    public class PlayersManager : MonoBehaviour
    {
        public static PlayersManager Instance { get; private set; }
        public List<Player> Players { get; set; }
        public GameSettings GameSettingsInstance { get; set; }
        public Category? CurrentCategory { get; set; } = null;
        
        // Singleton
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
