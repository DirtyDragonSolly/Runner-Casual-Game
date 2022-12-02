using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] Transform player;
    public Vector3 cameraOffset;
    
    private void Update()
    {
        transform.position = player.position + cameraOffset;
    }
}
