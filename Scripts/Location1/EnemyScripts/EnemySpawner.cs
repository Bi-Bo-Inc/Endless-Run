using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    
    public GameObject[] enemy = new GameObject[2];
    public static bool isSpawnerOn = true;
    [SerializeField]
    private float[] line = new float[5];
    [SerializeField]
    private float time;
  
    private void Start()
    {
        StartCoroutine(SpawnEnemy());
        StartCoroutine(TimeDecrease());
        
    }
    
    private void Spawn()
    {
        Instantiate(enemy[Random.Range(0, 3)], new Vector2(13, line[Random.Range(0, 6)]), Quaternion.identity);
    }

    IEnumerator TimeDecrease()
    {
        while(isSpawnerOn)
        {
            yield return new WaitForSecondsRealtime(1f);
            if (time > 2f)
                time -= 0.015f;
            else if (time == 0.2f)
                time = 0.2f;
        }
    }

   IEnumerator SpawnEnemy()
    {
        yield return new WaitForSecondsRealtime(5f);
        Spawn();
        while (isSpawnerOn)
        {
            yield return new WaitForSecondsRealtime(time);
            Spawn();
        }
    }


}
