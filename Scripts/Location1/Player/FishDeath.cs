using UnityEngine;

public class FishDeath : MonoBehaviour
{
    public GameObject deathMenuUI, scoreUI, scoreValueUI, pauseButtonUI, reloadButtonUI, highScoreUI, highScoreValueUI; 
      
    public GameObject spawnEnemy, ScoreManager;
    private SpawnEnemy SE;
    private Rigidbody2D rb;

    public static bool IsDeath = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SE = spawnEnemy.GetComponent<SpawnEnemy>();
        //FishPlayer = GetComponent<Animation>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            deathMenuUI.SetActive(true);
            scoreUI.SetActive(false);
            scoreValueUI.SetActive(false);
            highScoreUI.SetActive(false);
            highScoreValueUI.SetActive(false);
            pauseButtonUI.SetActive(false);
            reloadButtonUI.SetActive(false);

            SE.IsSpawner(false);
            ScoreScript.scoreIncreasing = false;
            GetComponent<PolygonCollider2D>().enabled = false;

            IsDeath = true;
        }
    }

    private float fishRotation = 0; //начальное положение
    private float fishAcceleration = 2f; //поворот
    private float maxFishRotation = 180f;

    private void FixedUpdate()
    {
        if (IsDeath)
        {
            GetComponent<Animator>().enabled = false;
            FloatingUp();
        }
    }

    private void FloatingUp()
    {
        //transform.localScale = new Vector2(0.8527528f, -0.9311681f);

        if ((fishRotation >= 0) && (fishRotation < maxFishRotation))
        {
            transform.rotation = Quaternion.Euler(0, 0, fishRotation);
            fishRotation += fishAcceleration;
        }

        rb.velocity = new Vector2(0, 2);
        if (gameObject.transform.position.y > 10)
        {
            Destroy(gameObject);
        }
    }
}
