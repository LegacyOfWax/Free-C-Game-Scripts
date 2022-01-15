using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationX : MonoBehaviour
{
    public float speed = 100f;

    void Update()
    {
        transform.Rotate(Vector3.right * speed * Time.deltaTime);
    }
}
