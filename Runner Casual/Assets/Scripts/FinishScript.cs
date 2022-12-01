using UnityEngine;

public class FinishScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("You won!");
        }
    }
}
