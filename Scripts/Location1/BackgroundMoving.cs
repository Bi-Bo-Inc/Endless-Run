using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMoving : MonoBehaviour
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
        if (gameObject.transform.position.x < -20)
        {
            Destroy(gameObject);
        }
    }
}
