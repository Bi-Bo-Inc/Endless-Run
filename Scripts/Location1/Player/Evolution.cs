using UnityEngine.SceneManagement;
using UnityEngine;


public class Evolution : MonoBehaviour
{
    

    public GameObject PlayerFish2, PlayerFish;
    public GameObject scoreValue;
    int scoreForEvol = 0;
    
    public int scoreGoal;

    public GameObject spawnEnemy;    

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
   
}
    