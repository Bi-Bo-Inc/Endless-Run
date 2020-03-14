using System.Collections;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject EnemyFishType1, EnemyFishType2, EnemyFishType3;
    public float minTimeSpawnEnemy, maxTimeSpawnEnemy;
    private float time;
    private float y = 0; //переменная для выбора линии куда кинуть enemy

    void Start()
    {
        StartCoroutine(SpawnerEnemy());
    }

    private float SetRandomLine()
    {
        int randLine = Random.Range(0, 3); //какая-то херня с switch ,тут указан диапазон из 4 чисел потому,что он игнорирует последнее
                                           //для трех кейсов нужно 4 значения ,ибо свитч берет диапазон [0;3)
        int randForCase2 = -1;

        if (y == 3.178791f)
            randLine = Random.Range(1, 3);

        else if (y == -0.17f)
        {
            int tmpRand = Random.Range(0, 2);

            if (tmpRand == 1)
            {
                randForCase2 = 2;
            }
            else if (tmpRand == 0)
            {
                randForCase2 = 0;
            }
            randLine = randForCase2;
        }

        else if (y == -3.15f)
            randLine = Random.Range(0, 2);

        switch (randLine)
        {
            case 0:
                y = 3.178791f;
                break;
            case 1:
                y = -0.17f;
                break;
            case 2:
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
            int randFishEnemyChoose = Random.Range(1,4);
            GameObject curFish;

            if (randFishEnemyChoose == 1)
            {
                curFish = EnemyFishType1;
                //спавн для первого вида рыбы
                time = Random.Range(minTimeSpawnEnemy / 5, maxTimeSpawnEnemy / 5);
                yield return new WaitForSeconds(time);
                y = SetRandomLine();
                Instantiate(curFish, new Vector2(30f, y), Quaternion.identity);
            }
            else if(randFishEnemyChoose == 2)
            {
                curFish = EnemyFishType2;
                //спавн для второго вида рыбы
                time = Random.Range(minTimeSpawnEnemy / 5, maxTimeSpawnEnemy / 5);
                yield return new WaitForSeconds(time);
                y = SetRandomLine();
                Instantiate(curFish, new Vector2(30f, y), Quaternion.identity);
            }
            else if (randFishEnemyChoose == 3)
            {
                curFish = EnemyFishType3;
                //спавн для второго вида рыбы
                time = Random.Range(minTimeSpawnEnemy / 5, maxTimeSpawnEnemy / 5);
                yield return new WaitForSeconds(time);
                y = SetRandomLine();
                Instantiate(curFish, new Vector2(30f, y), Quaternion.identity);
            }
        }
    }
}
