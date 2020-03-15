using UnityEngine.SceneManagement;
using UnityEngine;

public class Evolution : MonoBehaviour
{
    public GameObject scoreValue;
    int scoreForEvol;
    private void Start()
    {
        scoreForEvol = ScoreScript.scoreValue;
    }
    private void FixedUpdate()
    {
        scoreForEvol = ScoreScript.scoreValue;
        if (scoreForEvol <= 120)
            Evolve(2);
        else if (scoreForEvol > 125 && scoreForEvol <= 250)
            Evolve(3);


    }
    private void Evolve(int codeForEvolve)
    {
        SceneManager.LoadScene(codeForEvolve);
    }
}
    