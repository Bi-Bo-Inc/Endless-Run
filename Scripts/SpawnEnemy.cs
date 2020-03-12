using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject Enemy;
    public float time;


    void Start()
    {
        StartCoroutine(SpawnerEnemy());
    }

    void Repeat()
    {
        StartCoroutine(SpawnerEnemy());
    }

    IEnumerator SpawnerEnemy()
    {
        yield return new WaitForSeconds(time);
        Instantiate(Enemy, SpawnPos.position, Quaternion.identity);
        Repeat();
    }
   
}
