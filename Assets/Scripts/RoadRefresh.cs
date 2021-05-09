using UnityEngine;
using UnityEditor;

public class RoadRefresh : MonoBehaviour
{
    public float speed = 0.7f;
    public GameObject road;
    void FixedUpdate()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y < -8.0f)
        {
            Instantiate(road, new Vector3(-0.1f, 12.39f, 0), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
