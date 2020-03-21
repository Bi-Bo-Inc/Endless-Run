using UnityEngine;

public class MoveEntity : MonoBehaviour
{
    public float Entityspeed;
    public Vector2 moveEntity;

    void Update()
    {
        VodoroslMoving();
    }

    void VodoroslMoving()
    {
        transform.Translate(Vector2.left * Entityspeed * Time.smoothDeltaTime);
        if (gameObject.transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }

   
}