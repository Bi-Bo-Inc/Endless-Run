using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    private ScoreScript scoreManager;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)&&(FishDeath.IsDeath == false))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
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
        SceneManager.LoadScene(0);

        ScoreScript.scoreValue = 0;
        FishDeath.IsDeath = false;
    }
    /*
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }*/
}
