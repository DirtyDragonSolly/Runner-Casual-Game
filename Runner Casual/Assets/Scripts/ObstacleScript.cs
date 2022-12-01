using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    private string playerTag = "Player";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == playerTag)
        {            
            collision.gameObject.GetComponent<PlayerMovement>().enabled = false;
        }
    }
}
