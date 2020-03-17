using UnityEngine.SceneManagement;
using UnityEngine;


public class Evolution : MonoBehaviour
{
    private FishDeath death;
    public GameObject PlayerFish2, PlayerFish;
    public GameObject scoreValue;
    int scoreForEvol = 0;
    int codeForEvolve = -1;
    public int scoreGoal;

    public GameObject spawnEnemy;
    private SpawnEnemy SE;

    private void Start()
    {
        scoreForEvol = ScoreScript.scoreValue;
        SE = spawnEnemy.GetComponent<SpawnEnemy>();
    }
    private void FixedUpdate()
    {
        scoreForEvol = ScoreScript.scoreValue;
        /*
        if (scoreForEvol == scoreGoal - 5)
        {
            SE.IsSpawner(false);
        }
        */
        if (scoreForEvol == scoreGoal) 
        {      
            PlayerFish2.SetActive(true);
            PlayerFish.SetActive(false);
        }

    }
    private void Evolve(int codeForeEvolve)
    {
        SceneManager.LoadScene(codeForEvolve);
    }
}
    