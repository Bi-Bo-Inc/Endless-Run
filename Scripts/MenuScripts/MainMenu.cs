using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
        ScoreScript.scoreValue = 0;

        FishDeath.IsDeath = false;
        ScoreScript.scoreIncreasing = true;

        SceneManager.LoadScene(1);
<<<<<<< Updated upstream:Scripts/MenuScripts/MainMenu.cs
=======
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
>>>>>>> Stashed changes:Scripts/Location1/MenuScripts/MainMenu.cs
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
