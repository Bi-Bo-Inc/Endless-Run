using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject Enemy;
    private float time;

    void Start()
    {
        StartCoroutine(SpawnerEnemy());
<<<<<<< HEAD
    }

    void Repeat()
    {
        StartCoroutine(SpawnerEnemy());
    }

    IEnumerator SpawnerEnemy()
    {
        time = Random.Range(1f, 5f);
        yield return new WaitForSeconds(time);
        Instantiate(Enemy, SpawnPos.position, Quaternion.identity);
        Repeat();
    }

   
   
=======
    }    

    IEnumerator SpawnerEnemy()
    {
        while (true)
        {
            time = Random.Range(1f, 5f);
            yield return new WaitForSeconds(time);
            Instantiate(Enemy, new Vector3(11f, Random.Range(-4f, 4f), 0f), Quaternion.identity);
        }    
    }   
>>>>>>> master
}
