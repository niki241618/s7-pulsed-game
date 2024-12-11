using UnityEngine;

public class ResetPlayerPref : MonoBehaviour
{
    private const string FirstTimeKey = "FirstTimeInScene";
    public void Reset_Player_Pref()
    {
        PlayerPrefs.DeleteKey(FirstTimeKey);
    }
}
