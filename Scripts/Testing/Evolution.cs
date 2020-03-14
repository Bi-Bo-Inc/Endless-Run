
//using UnityEngine;

//public class Evolution : MonoBehaviour
//{
//    public GameObject Brain;
//    public GameObject PlayerFish;
//    private int countEvolPiece = 0;
//    private bool isEvol = false;
//    private void OnCollisionEnter2D(Collision2D collision)
//    {
//        if (collision.gameObject.tag == "Player")
//        {
           
//            if (countEvolPiece < 100)
//            {
//                countEvolPiece += 1;
//                Destroy(gameObject);
//            }
//            else if (countEvolPiece == 100)
//            {
//                isEvol = true;
//            }
//        }
//    }
//    void OnTriggerEnter2D(Collider2D other)
//    {
//        = other.GetComponent<PlayerFish>();

        
//    }
//    private void FixedUpdate()
//    {
//        Debug.Log(countEvolPiece);
//    }
//}
