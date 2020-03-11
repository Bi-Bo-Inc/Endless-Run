using UnityEngine;

public class FishController : MonoBehaviour
{
    public float swimForce;

    private Rigidbody2D rb;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    private void Update()
    {
       if (Input.GetKey(KeyCode.UpArrow))
        {
            MovementUp();
        }
       
    }
    private void MovementUp()
    {
        rb.velocity = new Vector2(0, swimForce);       
        
    }

    
    private void FixedUpdate()
    {
        
    }
}