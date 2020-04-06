using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleCosMoving : MonoBehaviour
{
	[SerializeField]
	private float bubbleSpeedMin, bubbleSpeedMax, frequency = 20f, magnitude = 0.5f, minRandAmplit, maxRandAmplit;
	private float randForMagn, bubbleSpeed;

    Vector3 pos;

	private void Start()
    {
        bubbleSpeed = Random.Range(bubbleSpeedMin, bubbleSpeedMax);

		pos = transform.position;
		randForMagn = Random.Range(minRandAmplit, maxRandAmplit);
        
	}

    private void Update()
    {
        SinMove();
    }
   
	private void SinMove()
    {
        pos += transform.up * Time.deltaTime * bubbleSpeed;
        transform.position = pos + transform.right * Mathf.Cos(Time.time * frequency * (magnitude + randForMagn));
        if (gameObject.transform.position.y > 6)
        {
            Destroy(gameObject);
        }
    }
}
