﻿using System.Collections;
using UnityEngine;

public class SpawnEntity : MonoBehaviour
{
    public GameObject bubble,vodorosl0, vodorosl1;//, vodorosl2, vodorosl3, vodorosl4, vodorosl5, vodorosl6, vodorosl7, vodorosl8, vodorosl9;
    public float minTime, maxTime;
    private GameObject currentVodorosl;
    private void Start()
    {
        StartCoroutine(SpawnerEntityVodorosl());
        StartCoroutine(SpawnerEntityBubble());
    }

    private void SpawnVodorosl(GameObject curVodorosl)
    {
        GameObject vodorosl = curVodorosl;


        float y = Random.Range(0, 3);
        if (y == 0)
            y = -2.71f;
        else if (y == 1)
            y = -2.67f;
        else if (y == 2)
            y = -3.452664f;


        Instantiate(vodorosl, new Vector2(15f, y), Quaternion.identity);
    }

    private void ChooseVodorosl(int randVodorosl)
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
            int randVodorosl = Random.Range(0, 2);
            float time = Random.Range(minTime, maxTime);
            yield return new WaitForSeconds(time);
            ChooseVodorosl(randVodorosl);

        }
    }

    private void SpawnBubble()
    {
        float x = Random.Range(-9f, 12f);
        Instantiate(bubble, new Vector2(x,-5.8f),Quaternion.identity);
    }

    IEnumerator SpawnerEntityBubble()
    {
        while (true)
        {
            float time = Random.Range(0, 0.75f);
            yield return new WaitForSeconds(time);
            SpawnBubble();
        }
    }
}
