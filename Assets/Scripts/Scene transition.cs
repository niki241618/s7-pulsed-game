using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenetransition : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogError("Scene name is invalid or not set!");
        }
    }
}
