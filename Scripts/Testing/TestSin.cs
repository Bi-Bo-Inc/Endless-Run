using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSin : MonoBehaviour
{
    [SerializeField]
    private Vector2 dir;
    private void Update()
    {
        transform.Translate(a + b * sin(cx + d));

        pos -= transform.up * Time.deltaTime * moveSpeed;
        transform.position = pos + transform.up * Mathf.Cos(Time.time * frequency * (magnitude + randForMagn));
    }
}
