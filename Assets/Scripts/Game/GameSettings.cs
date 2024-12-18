using System;
using UnityEngine;

public class GameSettings : MonoBehaviour
{
    [Serializable]
    public enum GameLength
    {
        Short = 5,
        Medium = 10,
        Long = 15
    }
}


