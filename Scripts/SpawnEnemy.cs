using System.Collections;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject EnemyFishType1, EnemyFishType2;
    public float minTimeSpawnEnemy, maxTimeSpawnEnemy;
    private float time;
    private float y = 0; //переменная для выбора линии куда кинуть enemy
    void Start()
    {
        StartCoroutine(SpawnerEnemy());
    }    

    private float SetRandomLine()
    {

        
        int randLine = Random.Range(0,3); //какая-то херня с switch ,тут указан диапазон из 4 чисел потому,что он игнорирует последнее
                                          //для трех кейсов нужно 4 значения ,ибо свитч берет диапазон [0;3)
        if (y == 3.178791f)
            randLine = 1;
        else if (y == -0.17f)
            randLine = 2;
        else if (y == -3.15f)
            randLine = 0;
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
            //спавн для первого вида рыбы
            time = Random.Range(minTimeSpawnEnemy / 5, maxTimeSpawnEnemy / 5);
            yield return new WaitForSeconds(time);
            y = SetRandomLine();
            Instantiate(EnemyFishType1, new Vector2(11f, y), Quaternion.identity);

            //спавн для второго вида рыбы
            time = Random.Range(minTimeSpawnEnemy / 5, maxTimeSpawnEnemy / 5);
            yield return new WaitForSeconds(time);
            y = SetRandomLine();
            Instantiate(EnemyFishType2, new Vector2(11f, y), Quaternion.identity);
        }    
    }   
}
