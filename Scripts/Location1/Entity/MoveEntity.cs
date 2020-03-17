using UnityEngine;

public class MoveEntity : MonoBehaviour
{
    public float Entityspeed;
    public Vector2 moveEntity;

    void FixedUpdate()
    {
        VodoroslMoving();
       
    }

    void VodoroslMoving()
    {
        transform.Translate(Entityspeed * moveEntity);
        if (gameObject.transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }

   
}