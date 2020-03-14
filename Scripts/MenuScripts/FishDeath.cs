using UnityEngine;
using UnityEngine.SceneManagement;

public class FishDeath : MonoBehaviour
{
    public GameObject pauseMenuUI, scoreUI, scoreValueUI, pauseButtonUI, reloadButtonUI, highScoreUI, highScoreValueUI;    

    public static bool IsDeath = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            pauseMenuUI.SetActive(true);
            scoreUI.SetActive(false);
            scoreValueUI.SetActive(false);
            highScoreUI.SetActive(false);
            highScoreValueUI.SetActive(false);
            pauseButtonUI.SetActive(false);
            reloadButtonUI.SetActive(false);

            Time.timeScale = 0f;
            IsDeath = true;

            transform.localScale = new Vector2(0.8527528f, -0.9311681f);
        }
    }
}
