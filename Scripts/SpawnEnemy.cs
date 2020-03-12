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
    }    

    IEnumerator SpawnerEnemy()
    {
        while (true)
        {
            time = Random.Range(1f, 5f);
            yield return new WaitForSeconds(time);
            Instantiate(Enemy, new Vector2(11f, Random.Range(-4f, 4f)), Quaternion.identity);
        }    
    }   
}
