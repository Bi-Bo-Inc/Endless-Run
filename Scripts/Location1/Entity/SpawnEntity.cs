using System.Collections;
using UnityEngine;

public class SpawnEntity : MonoBehaviour
{
    public GameObject bubble,vodorosl0, vodorosl1;//, vodorosl2, vodorosl3, vodorosl4, vodorosl5, vodorosl6, vodorosl7, vodorosl8, vodorosl9;
    public float minTime, maxTime;//мин и макс окно для спавна ентити
    private GameObject currentVodorosl; //текущий выбор ентити для спавна
    private void Start() //запуск карутин для водорослей и пузырьков
    {
        StartCoroutine(SpawnerEntityVodorosl());
        StartCoroutine(SpawnerEntityBubble());
    }

    private void SpawnVodorosl(GameObject curVodorosl) //функция спавна водорослей,принимает в параметр рандомный объект
    {
        float y = Random.Range(0, 3); //выбор рандомной высоты для спавна ентити
        if (y == 0)
            y = -2.71f;
        else if (y == 1)
            y = -2.67f;
        else if (y == 2)
            y = -3.452664f;


        Instantiate(curVodorosl, new Vector2(15f, y), Quaternion.identity);
    }

    private void ChooseVodorosl(int randVodorosl) //функция выбора рандомной водоросли,при новых водорослях- добавить case 
    {
        switch (randVodorosl)
        {
            case 0:
                currentVodorosl = vodorosl0;
                SpawnVodorosl(currentVodorosl);
                break;
            case 1:
                currentVodorosl = vodorosl1;
                SpawnVodorosl(currentVodorosl);
                break;
            default:
                break;
        }

    }

    IEnumerator SpawnerEntityVodorosl() 
    {
        while (true)
        {
            int randVodorosl = Random.Range(0, 2); //выбираем переменную для switch в 29 строке
            float time = Random.Range(minTime, maxTime); //выбор рандомного времени для карутины в промежутке между min и max
            yield return new WaitForSeconds(time); //запуск функции ChooseVodorosl через time времени
            ChooseVodorosl(randVodorosl);

        }
    }

    private void SpawnBubble() //генератор пузыриков на -5.8 по Y оси и рандомному X между -9 и 12
    {
        float x = Random.Range(-9f, 12f);
        Instantiate(bubble, new Vector2(x,-5.8f),Quaternion.identity);
    }

    IEnumerator SpawnerEntityBubble() //карутина для цикла спавна пузыриков
    {
        while (true)
        {
            float time = Random.Range(0, 0.75f);
            yield return new WaitForSeconds(time);
            SpawnBubble();
        }
    }
}
