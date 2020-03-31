using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleMoving : MonoBehaviour
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
        ////ChooseMovement();
	}

    private float randForMovement;
    ////private bool isSinMovement;
    //private void ChooseMovement()
    //{
    //    randForMovement = Random.Range(0, 2);
    //    if (randForMovement == 0)
    //    {
    //        isSinMovement = false;
    //    }
    //    else if (randForMovement == 1)
    //    {
    //        isSinMovement = true;
    //    }
    //    else print("Error");
    //}

    private void Update()
    {
        //if (!isSinMovement)
        //    Move();
        //else
            SinMove();
    }
    //private void Move()
    //{
    //    transform.Translate(Vector2.up * bubbleSpeed * Time.smoothDeltaTime);
    //    if (gameObject.transform.position.y > 6)
    //    {
    //        Destroy(gameObject);
    //    }
    //}

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
