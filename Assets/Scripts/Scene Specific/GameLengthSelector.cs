using System;
using Players;
using UnityEngine;

public class GameLengthSelector : MonoBehaviour
{
    [SerializeField] private SceneTransition sceneTransition;
    private PlayersManager playersManager;
    private void Start()
    {
        playersManager = PlayersManager.Instance;
    }

    public void SelectGameLength(int length)
    {
        playersManager.GameLength = (GameSettings.GameLength) length;
        sceneTransition.ChangeScene("SelectPlayersSceen");
    }
}
