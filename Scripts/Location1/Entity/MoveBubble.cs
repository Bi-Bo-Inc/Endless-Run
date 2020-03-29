using UnityEngine;

public class MoveBubble : MonoBehaviour
{
    private float bubbleSpeedMin=0.75f, bubbleSpeedMax=1.5f;
    private Vector2 moveBubble;
    private float bubbleSpeed;

    private void Start()
    {
        bubbleSpeed = Random.Range(bubbleSpeedMin, bubbleSpeedMax);
        moveBubble = new Vector2(-1f, Random.Range(1.0f, 1.5f));
    }

    private void FixedUpdate()
    {
        BubbleMoving();
    }

    private void BubbleMoving()
    {
        
        transform.Translate(moveBubble * bubbleSpeed * Time.smoothDeltaTime);
        if (gameObject.transform.position.y > 6)
        {
            Destroy(gameObject);
        }
    }
}
