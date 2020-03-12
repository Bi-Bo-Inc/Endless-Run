using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBonusHP : MonoBehaviour
{
    public Transform SpawnPosHP;
    public GameObject BonusHP;
    private float timeForHP;


    void Start()
    {
        StartCoroutine(BonusHealthPoint());
    }

    void RepeatHP()
    {
        StartCoroutine(BonusHealthPoint());
    }

    IEnumerator BonusHealthPoint()
    {
        timeForHP = Random.Range(1f, 5f);
        yield return new WaitForSeconds(timeForHP);
        Instantiate(BonusHP, SpawnPosHP.position, Quaternion.identity);
        RepeatHP();
    }



}
