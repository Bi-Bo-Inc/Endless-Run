using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleMenuSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject[] bubbles = new GameObject[0];
    [SerializeField]
    private float timeMinBubble, timeMaxBubble;
    private float lineBubble, time;

    private void Start()
    {
        StartCoroutine(BubblesSpawner());
        
    }

    private void SpawnBubble()
    {
        lineBubble = Random.Range(-10f, 12f);
        //Instantiate(bubbles[0], new Vector2(lineBubble, -6f), Quaternion.identity);
        Instantiate(bubbles[Random.Range(0, bubbles.Length)], new Vector2(lineBubble, -6f), Quaternion.identity); //раскоментить при кол-во пузырей больше 1 и закоментить строчку выше
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
}
