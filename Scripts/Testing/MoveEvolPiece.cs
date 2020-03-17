using UnityEngine;

public class MoveEvolPiece : MonoBehaviour
{
    public float speed;
    public Vector2 move;

    void FixedUpdate()
    {
        EvolPieceMoving();
    }

    void EvolPieceMoving()
    {
        transform.Translate(move * speed);
        if (gameObject.transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }
}
