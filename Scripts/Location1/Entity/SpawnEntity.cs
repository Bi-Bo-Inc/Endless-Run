using System.Collections;
using UnityEngine;

public class SpawnEntity : MonoBehaviour
{
    [SerializeField]
    private GameObject[] bubbles = new GameObject[0], vodorosli = new GameObject[1];
    [SerializeField]
    private float timeMinBubble, timeMaxBubble,timeMinVodorosl, timeMaxVodorosl;

    private float lineBubble,lineVodorosl,time;
    private void Start()
    {
        StartCoroutine(BubblesSpawner());
        StartCoroutine(VodorosliSpawner());
    }

    private void SpawnBubble()
    {
        lineBubble = Random.Range(-9.2f, 20f);
        Instantiate(bubbles[0], new Vector2(lineBubble, -6.3f), Quaternion.identity);
        //Instantiate(bubbles[Random.Range(0, 3)], new Vector2(lineBubble, -6.3f), Quaternion.identity); раскоментить при кол-во пузырей больше 1 и закоментить строчку выше
    }

    IEnumerator BubblesSpawner()
    {
        while (true)
        {
            time = Random.Range(timeMinBubble, timeMaxBubble);
            yield return new WaitForSecondsRealtime(time);
            SpawnBubble();
        }
    }

    private void SpawnVodorosl()
    {
        lineVodorosl = Random.Range(-2.55f, -3.5f);
        Instantiate(vodorosli[Random.Range(0, 2)], new Vector2(13, lineVodorosl), Quaternion.identity);
    }

    IEnumerator VodorosliSpawner()
    {
        while (true)
        {
            time = Random.Range(timeMinVodorosl, timeMaxVodorosl);
            yield return new WaitForSecondsRealtime(time);
            SpawnVodorosl();
        }
    }

}
