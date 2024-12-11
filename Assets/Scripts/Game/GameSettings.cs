using UnityEngine;

public class GameSettings : MonoBehaviour
{
    public enum GameLength
    {
        Short = 5,
        Medium = 10,
        Long = 15
    }
    public static int SelectedRounds { get; private set; } = (int)GameLength.Medium;

    public void SetRounds(string round)
    {
        if (System.Enum.TryParse(round, out GameLength gameLength))
        {
            SelectedRounds = (int)gameLength;
            Debug.Log($"Selected rounds: {SelectedRounds}");
        }
        else
            Debug.Log("Invalid game length.");
    }
}


