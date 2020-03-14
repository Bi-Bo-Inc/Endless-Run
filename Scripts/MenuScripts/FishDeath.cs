using UnityEngine;
using UnityEngine.SceneManagement;

public class FishDeath : MonoBehaviour
{
    public GameObject pauseMenuUI, scoreUI, scoreValueUI, pauseButtonUI, reloadButtonUI;

    Vector3 pos1, pos2;
    public static bool IsDeath = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            pauseMenuUI.SetActive(true);
            scoreUI.SetActive(false);
            scoreValueUI.SetActive(false);
            pauseButtonUI.SetActive(false);
            reloadButtonUI.SetActive(false);
            pos1 = transform.position;
            pos2 = new Vector3(-7.281992f, 4f, 0f);
            transform.localScale = new Vector2(0.8527528f, -0.9311681f);
            transform.position = Vector3.MoveTowards(pos1, pos2, Time.deltaTime * 2);
            //Time.timeScale = 0f;
            IsDeath = true;
            
        }
    }
}
