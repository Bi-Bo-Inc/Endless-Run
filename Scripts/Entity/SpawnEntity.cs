using System.Collections;
using UnityEngine;

public class SpawnEntity : MonoBehaviour
{
    public GameObject vodorosl0, vodorosl1;//, vodorosl2, vodorosl3, vodorosl4, vodorosl5, vodorosl6, vodorosl7, vodorosl8, vodorosl9;
    public float minTime, maxTime;
    private GameObject currentVodorosl;
    private void Start()
    {
        StartCoroutine(SpawnerEntityVodorosl());
    }

    private void Spawn(GameObject curVodorosl)
    {
        GameObject vodorosl = curVodorosl;
        Instantiate(vodorosl, new Vector2(15f, -4f), Quaternion.identity);
    }

    private void ChooseVodorosl(int randVodorosl)
    {
        switch (randVodorosl)
        {
            case 0:
                currentVodorosl = vodorosl0;
                Spawn(currentVodorosl);
                break;
            case 1:
                currentVodorosl = vodorosl1;
                Spawn(currentVodorosl);
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
}
