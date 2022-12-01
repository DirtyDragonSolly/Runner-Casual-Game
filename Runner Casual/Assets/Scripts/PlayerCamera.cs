using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] Transform Player;
    public Vector3 cameraOffset;
    
    private void Update()
    {
        transform.position = Player.position + cameraOffset;
    }
}
