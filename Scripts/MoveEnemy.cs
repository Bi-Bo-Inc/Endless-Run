using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    private float speed;
 
    public Vector2 move;
    void Start()
    {
        speed = Random.Range(0.09f, 0.3f);
        
    }

    
    void FixedUpdate()
    {
        transform.Translate(move * speed);
        if(gameObject.transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }
}