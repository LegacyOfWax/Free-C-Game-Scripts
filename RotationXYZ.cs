using UnityEngine;

public class RotationXYZ : MonoBehaviour
{
    public float speed = 100f;

    void Update()
    {
        transform.Rotate(Vector3.one * speed * Time.deltaTime);
    }
}

