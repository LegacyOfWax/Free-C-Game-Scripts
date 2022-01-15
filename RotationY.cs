using UnityEngine;

public class RotationY : MonoBehaviour
{
    public float speed = 100f;

    void Update()
    {
        transform.Rotate(Vector3.down * speed * Time.deltaTime);
    }
}
