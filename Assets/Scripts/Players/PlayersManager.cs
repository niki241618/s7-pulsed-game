using System.Collections.Generic;
using UnityEngine;

namespace Players
{
    public class PlayersManager : MonoBehaviour
    {
        public static PlayersManager Instance { get; private set; }
        public List<Player> Players { get; set; }
        
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
