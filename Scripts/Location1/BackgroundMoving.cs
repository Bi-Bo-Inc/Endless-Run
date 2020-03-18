using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMoving : MonoBehaviour //ctrl c + ctrl скрипт передвижения,поменял только координату x в 18 строке
{
    public float speed;
    public Vector2 vector;

    void FixedUpdate()
    {
        BackgroundMove();
    }

    void BackgroundMove()
    {
        transform.Translate(vector * speed);
        if (gameObject.transform.position.x < -30)
        {
            Destroy(gameObject);
        }
    }
}
