using UnityEngine;

public class MoveEntity : MonoBehaviour
{
    [SerializeField]
    private float Entityspeed;
    

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