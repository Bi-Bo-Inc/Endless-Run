using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleUpMoving : MonoBehaviour
{
    [SerializeField]
    private float bubbleSpeedMin, bubbleSpeedMax;
    private float bubbleSpeed;

    private void Start()
    {
        bubbleSpeed = Random.Range(bubbleSpeedMin, bubbleSpeedMax);
    }
    private void Update()
    {
        VodoroslMoving();
    }

    void VodoroslMoving()
    {
        transform.Translate(Vector2.up * bubbleSpeed * Time.smoothDeltaTime);
        if (gameObject.transform.position.y > 6)
        {
            Destroy(gameObject);
        }
    }
}
