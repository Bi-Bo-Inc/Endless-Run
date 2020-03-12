using System.Collections;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject EnemyFishType1, EnemyFishType2;
    private float time;
    private float y = 0;
    void Start()
    {
        StartCoroutine(SpawnerEnemy());
    }    

    private float SetRandomLine()
    {
        int randLine = Random.Range(1,4) ;
        switch (randLine)
        {
            case 1:
                y = 3.178791f;
                break;
            case 2:
                y = -0.17f;
                break;
            case 3:
                y = -3.15f;
                break;
            default:
                break;
        }
        return y;
    }

    IEnumerator SpawnerEnemy()
    {
        while (true)
        {
            time = Random.Range(1f, 2f);
            yield return new WaitForSeconds(time);
            y = SetRandomLine();
            Instantiate(EnemyFishType1, new Vector2(11f, y), Quaternion.identity);

            time = Random.Range(1f, 2f);
            yield return new WaitForSeconds(time);
            y = SetRandomLine();
            Instantiate(EnemyFishType2, new Vector2(11f, y), Quaternion.identity);
        }    
    }   
}
