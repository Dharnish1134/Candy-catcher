using UnityEngine;

public class candyScript : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //score is to be implemented
            Destroy(gameObject);
        }

        else if (collision.gameObject.tag == "Boundary")
        {
            //lives is to be implemented
            Destroy(gameObject);
        }
    }
}
