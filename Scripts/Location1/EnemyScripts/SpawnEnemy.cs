using System.Collections;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject EnemyFishType1, EnemyFishType2, EnemyFishType3;
    private GameObject curFish; //переменная выбора рыбы для спавна

    [SerializeField]
    private float time; //asd

    private float y = 0; //переменная для выбора линии куда кинуть enemy

    public static bool isSpawnerOn = true;

    void Start()
    {        
        StartCoroutine(SpawnerEnemy());
    }
    
    private float SetRandomLine()
    {
        int randLine = Random.Range(0, 3); //какая-то херня с switch ,тут указан диапазон из 4 чисел потому,что он игнорирует последнее
                                           //для трех кейсов нужно 4 значения ,ибо свитч берет диапазон [0;3)
        int randForCase2 = -1;
        { //так надо,не трогать!
            if (y == 3.178791f)
                randLine = Random.Range(1, 3);

            else if (y == -0.17f) //не вникайте,потом подправлю,пока просто не трогайте
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
        }
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
    private void TimeDecrease() //уменьшение времени после каждой заспавненной рыбы
    {
        if (time > 0.75f)
            time -= 0.015f; //увеличение скорости спавна рыб,можно менять,но смотрите на ограничение IF,который выше 
        else
        {
            time = 0.75f;
        }
    }
   
    private void ChooseRandFish() //выбор полупокера для спавна
    {
        y = SetRandomLine();
        Instantiate(curFish, new Vector2(20f, y), Quaternion.identity);
    }

    IEnumerator SpawnerEnemy()
    {
        while (isSpawnerOn)
        {
            TimeDecrease();
            int randFishEnemyChoose = Random.Range(1,4); //выбор номера рыбы для спавна
                                                         //номер решает какая рыба будет выбранна для спавна
            if (randFishEnemyChoose == 1) //спавн для первого вида рыбы
            {
                curFish = EnemyFishType1;          
                yield return new WaitForSeconds(time);
                ChooseRandFish();
            }
            else if (randFishEnemyChoose == 2) //спавн для второго вида рыбы
            {
                curFish = EnemyFishType2;
                yield return new WaitForSeconds(time);
                ChooseRandFish();
            }
            else if (randFishEnemyChoose == 3) //спавн для третьего вида рыбы
            {
                curFish = EnemyFishType3;
                yield return new WaitForSeconds(time);
                ChooseRandFish();
            }
        }
    }
}
