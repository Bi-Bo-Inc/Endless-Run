using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
<<<<<<< HEAD
    //public Transform SpawnPos;
=======
    public Transform SpawnPos;
>>>>>>> c061e992cd7a1cc358019f6ae8826296bf89f8c7
    public GameObject Enemy;
    private float time;


    void Start()
    {
        StartCoroutine(SpawnerEnemy());
    }

<<<<<<< HEAD
    
=======

>>>>>>> c061e992cd7a1cc358019f6ae8826296bf89f8c7
    IEnumerator SpawnerEnemy()
    {
        while (true)
        {
<<<<<<< HEAD
            time = Random.Range(2f, 5f);
            yield return new WaitForSeconds(time);
            Instantiate(Enemy, new Vector3 (11f, Random.Range(-4f,4f),0f), Quaternion.identity);
        }  
    }
=======
            time = Random.Range(1f, 5f);
            yield return new WaitForSeconds(time);
            Instantiate(Enemy, SpawnPos.position, Quaternion.identity);
            
        }
    }
   
>>>>>>> c061e992cd7a1cc358019f6ae8826296bf89f8c7
}
