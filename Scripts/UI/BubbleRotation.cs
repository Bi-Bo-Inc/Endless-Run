using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleRotation : MonoBehaviour
{
    [SerializeField]
    private int rotateCountMin, rotateCountMax;
    private int rotateCount;
    
    Quaternion rotationZ;
    
    private void Start()
    {
        rotateCount = Random.Range(rotateCountMin, rotateCountMax);
    }

    void FixedUpdate()
    {
        
        Rotation();
    }

    private void Rotation()
    {
        rotationZ = Quaternion.AngleAxis(rotateCount, new Vector3(0, 0, 1));
        transform.rotation *= rotationZ;
    }
}
