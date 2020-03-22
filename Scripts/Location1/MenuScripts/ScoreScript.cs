using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text score;
    public Text highScore;

    public static int scoreValue = 0; //значение текущего рекорда
    public static int highScoreValue = 0; //значение наивысшего рекорда

    private int pointsPerSecond = 1; //скорость обновления рекорда 
    public static bool scoreIncreasing = true;
    

    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScoreValue = PlayerPrefs.GetInt("HighScore");
        }
        StartCoroutine(Score());
        
    }
    
    void FixedUpdate()
    {
        if (scoreValue > highScoreValue)
        {
            highScoreValue = scoreValue;
            PlayerPrefs.SetInt("HighScore", highScoreValue);
        }
        score.text = "" + scoreValue;
        highScore.text = "" + highScoreValue;
    }
    
    

    IEnumerator Score()
    {
        yield return new WaitForSeconds(2f);
        while (!FishDeath.IsDeath)
        {
            yield return new WaitForSeconds(pointsPerSecond);
            scoreValue += 1;
            if (FishDeath.IsDeath)
            scoreValue--;
        }
        
    }
}
