using UnityEngine;

public class PlayrLight : MonoBehaviour
{
    public Transform Player;
    Vector3 _lightPosition = new Vector3(0, 0, -0.5f);
    
    void Update()
    {
        transform.position = Player.position + _lightPosition;
    }
}
