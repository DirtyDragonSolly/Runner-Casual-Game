using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    private string _playerTag = "Player";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == _playerTag)
        {            
            collision.gameObject.GetComponent<PlayerMovement>().enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }
}
