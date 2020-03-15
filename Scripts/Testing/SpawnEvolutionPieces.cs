using System.Collections;
using UnityEngine;

public class SpawnEvolutionPieces : MonoBehaviour
{
    public GameObject EvolPiece;
    private float y;
    private void Start()
    {
        StartCoroutine(SpawnEvolPieces());
    }


    IEnumerator SpawnEvolPieces()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            SpawnPiece();
        }
    }

    private void EatPiece()
    {

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
    private void SpawnPiece() //выбор полупокера для спавна
    {
        y = SetRandomLine();
        Instantiate(EvolPiece, new Vector2(30f, y), Quaternion.identity);
    }
}
