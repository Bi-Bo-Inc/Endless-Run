using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float speed; 
    public Vector2 move;
    
    void FixedUpdate()
    {
        EnemyMoving();
    }

    void EnemyMoving()
    {
        transform.Translate(move * speed);
        if (gameObject.transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }
}