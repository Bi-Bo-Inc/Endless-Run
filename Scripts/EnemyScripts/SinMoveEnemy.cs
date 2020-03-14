using UnityEngine;

public class SinMoveEnemy : MonoBehaviour
{
	[SerializeField]
	private float moveSpeed = 3f;

	[SerializeField]
	private float frequency = 20f;

	[SerializeField]
	private float magnitude = 0.5f;
	public float minRandAmplit;
	public float maxRandAmplit;

	Vector3 pos;

	void Start()
	{
		pos = transform.position;
		minRandAmplit = Random.Range(0.1f, 0.4f);
	}

	void FixedUpdate()
	{
		MoveLeft();
		
	}

	void MoveLeft()
	{
		
		pos -= transform.right * Time.deltaTime * moveSpeed;
		transform.position = pos + transform.up * Mathf.Sin(Time.time * frequency  * (magnitude+ minRandAmplit));
	}
}