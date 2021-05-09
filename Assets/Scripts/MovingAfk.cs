using UnityEngine;

public class MovingAfk : MonoBehaviour
{
public float speed = 2.0f;
void FixedUpdate()
{
    transform.Translate(Vector3.forward * speed * Time.deltaTime);
    if (transform.position.y < -6)
        Destroy(gameObject);
}
}