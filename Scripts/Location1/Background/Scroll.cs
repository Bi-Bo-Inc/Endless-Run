using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    [SerializeField]
    private float speed;

    public Transform neighbour;

    void Update()
    {
        Move();
    }

    public void Move()
    {
        transform.Translate(Vector2.left * speed * Time.smoothDeltaTime);
        if (gameObject.transform.position.x < -30)
        {
            SnapToNeighbour();
        }
    }

    public void SnapToNeighbour()
    {
        transform.position = new Vector2(neighbour.position.x, transform.position.y);    
    }
}



