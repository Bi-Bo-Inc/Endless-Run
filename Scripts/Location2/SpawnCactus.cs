using System.Collections;
using UnityEngine;

public class SpawnCactus : MonoBehaviour
{
    public GameObject CactusType1, CactusType2;
    public float minTime, maxTime;
    private GameObject currentCactus;

    
    void Start()
    {
        StartCoroutine(SpawnerCactus());
    }

    private void Spawn(GameObject curCactus)
    {
        GameObject cactus = curCactus;
        Instantiate(cactus, new Vector2(15f, -2.1f), Quaternion.identity);
    }

    private void ChooseCactus(int randCactus)
    {
        switch (randCactus)
        {
            case 0:
                currentCactus = CactusType1;
                Spawn(currentCactus);
                break;
            case 1:
                currentCactus = CactusType2;
                Spawn(currentCactus);
                break;
            default:
                break;
        }

    }
    IEnumerator SpawnerCactus()
    {
        while (true)
        {
            int randCactus = Random.Range(0, 2);
            float time = Random.Range(minTime, maxTime);
            yield return new WaitForSeconds(time);
            ChooseCactus(randCactus);

        }
    }
    
}
