using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public static bool GameIsPaused = false;
   
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Raload()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
        SpawnEnemy.isSpawnerOn = true;

        ScoreScript.scoreValue = 0;
        FishDeath.IsDeath = false;
        ScoreScript.scoreIncreasing = true;
    }
    
    public void LoadMenu()
    {        
        SceneManager.LoadScene(0);        
    }    
}
