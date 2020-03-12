using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject Enemy;
    private float time;


    void Start()
    {
        StartCoroutine(SpawnerEnemy());
    }


    IEnumerator SpawnerEnemy()
    {
        while (true)
        {
            time = Random.Range(1f, 5f);
            yield return new WaitForSeconds(time);
            Instantiate(Enemy, SpawnPos.position, Quaternion.identity);
            
        }
    }
   
}
