using UnityEngine.SceneManagement;
using UnityEngine;

public class Evolution : MonoBehaviour
{
<<<<<<< Updated upstream
    public GameObject scoreValue;
    int scoreForEvol = 0;    
    public int scoreGoal1;
    public int scoreGoal2;
=======

    public GameObject PlayerFish2, PlayerFish;
    public GameObject scoreValue;
    int scoreForEvol = 0;
    int codeForEvolve = -1;
    public int scoreGoal;
    
    
>>>>>>> Stashed changes
    //public int scoreGoal3;
    private void Start()
    {
        scoreForEvol = ScoreScript.scoreValue;
    }
    private void FixedUpdate()
    {
        scoreForEvol = ScoreScript.scoreValue;
<<<<<<< Updated upstream
        if (scoreForEvol == scoreGoal1)
            Evolve(2);
        else if (scoreForEvol == scoreGoal2)
            Evolve(3);
    }

    private void Evolve(int codeForEvolve)
=======
        if (scoreForEvol == scoreGoal)
        {
           
            PlayerFish2.SetActive(true);
            PlayerFish.SetActive(false);
        }

    }
    private void Evolve(int codeForeEvolve)
>>>>>>> Stashed changes
    {
        SceneManager.LoadScene(codeForEvolve);
    }
}
    