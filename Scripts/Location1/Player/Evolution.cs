using UnityEngine.SceneManagement;
using UnityEngine;


public class Evolution : MonoBehaviour
{
    //public Animator anim;

    public GameObject PlayerFish2, PlayerFish;
    public GameObject scoreValue;
    int scoreForEvol = 0;
    //int codeForEvolve = -1;
    public int scoreGoal;

    public GameObject spawnEnemy;    

    private void Start()
    {
        //anim = GetComponent<Animator>();

        scoreForEvol = ScoreScript.scoreValue;
    }
    private void FixedUpdate()
    {
        scoreForEvol = ScoreScript.scoreValue;
        
        if (scoreForEvol == scoreGoal) 
        {
            //anim.Play("Evolution");
            PlayerFish2.SetActive(true);
            PlayerFish.SetActive(false);
        }
    }
    /*
    private void Evolve(int codeForeEvolve)
    {
        SceneManager.LoadScene(codeForEvolve);
    }
    */
}
    