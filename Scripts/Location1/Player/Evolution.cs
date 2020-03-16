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
    
    
    //public int scoreGoal3;
    private void Start()
    {
        scoreForEvol = ScoreScript.scoreValue;
    }
    private void FixedUpdate()
    {
        scoreForEvol = ScoreScript.scoreValue;
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
    