using UnityEngine;

public class candyScript : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            GameManager.instance.IncrementScore();
        }

        else if (collision.gameObject.tag == "Boundary")
        {
            GameManager.instance.Lifecount();
            Destroy(gameObject);
        }
    }
}
