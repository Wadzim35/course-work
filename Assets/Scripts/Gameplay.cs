using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameplay : MonoBehaviour
{
    public float speed = 5.4f;
    void Update()
    {
        //Vector3 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        //transform.position = new Vector3(pos.x, transform.position.y, transform.position.z);
        float horizont = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 horizontalDirection = new Vector3(horizont, 0, 0);
        transform.Translate(horizontalDirection.normalized * Time.deltaTime * speed);
        Vector3 verticalDirection = new Vector3(0, 0, vertical);
        transform.Translate(verticalDirection.normalized * Time.deltaTime * speed);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene(2);
        }
        
    }
}
