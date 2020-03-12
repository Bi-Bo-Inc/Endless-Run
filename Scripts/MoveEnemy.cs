using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float speed;
    public Vector2 move;
    
    void FixedUpdate()
    {
        transform.Translate(move * speed);
        if(gameObject.transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }
}