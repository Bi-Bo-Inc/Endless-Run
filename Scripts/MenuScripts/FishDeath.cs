using UnityEngine;
using UnityEngine.SceneManagement;

public class FishDeath : MonoBehaviour
{
    public GameObject pauseMenuUI, scoreUI, scoreValueUI, pauseButtonUI, reloadButtonUI, highScoreUI, highScoreValueUI;    

    public static bool IsDeath = false;
  
    public GameObject spawnEnemy, ScoreManager;
    private SpawnEnemy SE;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SE = spawnEnemy.GetComponent<SpawnEnemy>();
    }

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

            SE.IsSpawner(false);
            ScoreScript.scoreIncreasing = false;
            GetComponent<PolygonCollider2D>().enabled = false;



            //Time.timeScale = 0f;
            IsDeath = true;

            transform.localScale = new Vector2(0.8527528f, -0.9311681f);
        }
    }

    private void FixedUpdate()
    {
        if (IsDeath)
        {
            rb.velocity = new Vector2(0, 2);
            if (gameObject.transform.position.y > 10)
            {
                Destroy(gameObject);
            }

        }
    }
}
