using UnityEngine;

public class MoveBubble : MonoBehaviour
{
    public float Entityspeed;
    public Vector2 moveEntity;

    void FixedUpdate()
    {
        BubbleMoving();
    }

    void BubbleMoving()
    {
        transform.Translate(Entityspeed * moveEntity);
        if (gameObject.transform.position.y > 6)
        {
            Destroy(gameObject);
        }
    }
}
