using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    public static bool isSpawnerOn = true;


    public GameObject[] enemy = new GameObject[2]; //массив для зщагрузки врагов,при необходимости увеличения-выделить больше 
                                                   //памяти через число в скобках  и указать в инспекторе нужной кол-во
                                                   //слотов через переменную size

    [SerializeField]
    private float[] line = new float[5]; //массив линий для выплывания рыб,по аналогии с переменной выше,если нужно отредачить 
                                         //кол-во или положение линий,то заменяется цифра в скобках и остальные манипуляции
                                         //происходят в инспекторе

    [SerializeField]
    private float time;                  //переменная,задающая начальный интервал спавна врагов
  
    private void Start()  //запуск карутины
    {
        StartCoroutine(SpawnEnemy());
    }
    
    private void Spawn() //NEW 360 MLG SPAWNER V ODNU STROKU,A NE V 40 KAK BILO RAN'SHE,YA BI DAL RAZRABOTCHIKU ETOGO SPAWNERA
    {
        Instantiate(enemy[Random.Range(0, 3)], new Vector2(13, line[Random.Range(0, 6)]), Quaternion.identity);
    }

    private void TimeDecrease()  //нужно менять условия в if и else if ,а также в теле else if 
                                 //в соответствии с нужной минимальной скоростью
    {
        if (time > 0.55f)
            time -= 0.015f;
        else if (time == 0.55f)
            time = 0.55f;
    }

   IEnumerator SpawnEnemy() //сама карутина
    {
        yield return new WaitForSecondsRealtime(5f); //установить начальный запуск рыб(кд перед первым появлением)
        Spawn();
        while (isSpawnerOn)
        {
            yield return new WaitForSecondsRealtime(time);
            TimeDecrease();
            Spawn();
        }
    }

    


}
