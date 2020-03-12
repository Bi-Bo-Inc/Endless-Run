using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    //public Transform SpawnPos;
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
            time = Random.Range(2f, 5f);
            yield return new WaitForSeconds(time);
            Instantiate(Enemy, new Vector3 (11f, Random.Range(-4f,4f),0f), Quaternion.identity);
        }  
    }
}
