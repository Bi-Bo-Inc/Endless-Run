using UnityEngine.SceneManagement;
using UnityEngine;

public class Evolution : MonoBehaviour
{
    public GameObject scoreValue;
    int scoreForEvol = 0;
    int codeForEvolve = -1;
    public int scoreGoal1;
    public int scoreGoal2;
    //public int scoreGoal3;
    private void Start()
    {
        scoreForEvol = ScoreScript.scoreValue;
    }
    private void FixedUpdate()
    {
        scoreForEvol = ScoreScript.scoreValue;
        if (scoreForEvol == scoreGoal1)
            Evolve(2);
        else if (scoreForEvol == scoreGoal2)
            Evolve(3);
    }

    private void Evolve(int codeForeEvolve)
    {
        SceneManager.LoadScene(codeForEvolve);
    }
}
    