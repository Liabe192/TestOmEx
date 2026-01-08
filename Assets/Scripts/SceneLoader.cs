using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Call this from the Button
    public void LoadGameplayScene()
    {
        SceneManager.LoadScene("GameplayScene");
    }
}