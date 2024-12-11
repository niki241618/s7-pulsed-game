using UnityEngine;

public class PopUpManager : MonoBehaviour
{
    [SerializeField] private GameObject popUpWindow;
    private const string FirstTimeKey = "FirstTimeInScene";
    private void Start()
    {
        Debug.Log($"{PlayerPrefs.HasKey(FirstTimeKey)}: Before check");
        if (!PlayerPrefs.HasKey(FirstTimeKey))
        {
            Debug.Log($"{PlayerPrefs.GetInt(FirstTimeKey)}: After Check");
            popUpWindow.SetActive(true);
            PlayerPrefs.SetInt(FirstTimeKey,1);
            PlayerPrefs.Save();
        }
        else
        {
            popUpWindow.SetActive(false);
        }
    }
    public void CloseWindow()
    {
        popUpWindow.SetActive(false);
    }
}
