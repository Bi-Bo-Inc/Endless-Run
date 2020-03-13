using UnityEngine;

public class FishScale : MonoBehaviour
{
    public GameObject EnemyFishType1, EnemyFishType2; // рыбы,которые скейлятся
    float x, y; // координаты для рандом скейла


    void FixedUpdate() //тут вызывается изменение размера рыбы
    {
        SizeOfFish(EnemyFishType1, EnemyFishType2);
    }


    private void SizeOfFish(GameObject EnemyFishType1, GameObject EnemyFishType2) //функция изменения рыбы
    {
        x = Random.Range(-0.9f,-1.0f);
        y = x;


        //у объекта EnemyFishType меняется scale по X и Y
        EnemyFishType1.transform.localScale = new Vector3(x, -y, 0.0f);
        x = Random.Range(0.35f, 0.4f);
        y = x;
        EnemyFishType2.transform.localScale = new Vector3(x, y, 0.0f);

    }
   
}
