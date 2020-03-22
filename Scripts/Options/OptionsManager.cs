using UnityEngine.SceneManagement;

using UnityEngine;

public class OptionsManager : MonoBehaviour
{
   

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}