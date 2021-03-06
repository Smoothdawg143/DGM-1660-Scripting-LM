
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    GameObject Player;
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Player.GetComponent<PlayerController>().isGrounded = true;
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
         if (collision.collider.tag == "Ground")
        {
            Player.GetComponent<PlayerController>().isGrounded = false;

        }
    }

}
