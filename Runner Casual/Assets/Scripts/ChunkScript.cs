using UnityEngine;

public class ChunkScript : MonoBehaviour
{
    [Header ("Chunk Array:")]
    public ChunkArray myChankDistrict;
    private string playerTag = "Player";
    private int index;

    private void Start()
    {
        index = int.Parse(gameObject.name.Substring(gameObject.name.Length- 1));
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == playerTag)
            myChankDistrict.PlayerInside(index - 1);                    
    }
}
