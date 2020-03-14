using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0; //значение рекорда
    private float time = 1f; //скорость обновления рекорда

    Text score; 
    
    void Start()
    {
        score = GetComponent<Text>();
        StartCoroutine(Score());
    }
    
    void Update()
    {
        score.text = "" + scoreValue;
    }

    IEnumerator Score()
    {
        yield return new WaitForSeconds(2f);
        while (true)
        {
            yield return new WaitForSeconds(time);
            scoreValue += 1;
        }
    }
}
