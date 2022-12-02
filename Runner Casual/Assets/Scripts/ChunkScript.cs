using UnityEngine;

public class ChunkScript : MonoBehaviour
{
    [Header ("Chunk Array:")]
    public ChunkArray myChankDistrict;
    private string playerTag = "Player";
    private int _index;

    [Header ("Generation obstacles")]
    bool _hasGenerated = false;
    [SerializeField] GameObject[] obstacles;

    private void Start()
    {
        _index = int.Parse(gameObject.name.Substring(gameObject.name.Length- 1));
    }
    
    private void OnEnable()
    {
        for (int i = 0; i < Random.Range(5, 100); i++)
        {
            if (!_hasGenerated)
            {
                Instantiate(
                    obstacles[Random.Range(0, obstacles.Length - 1)], 
                    new Vector3(
                   /*X*/Random.Range(
                            transform.position.x - gameObject.GetComponent<BoxCollider>().size.x / 2, 
                            transform.position.x + gameObject.GetComponent<BoxCollider>().size.x / 2),
                   /*Y*/0,
                   /*Z*/Random.Range(
                            transform.position.z - gameObject.GetComponent<BoxCollider>().size.z / 2, 
                            transform.position.z + gameObject.GetComponent<BoxCollider>().size.z / 2)),
                    new Quaternion(), 
                    transform);                
            }
        }
        _hasGenerated = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == playerTag)
            myChankDistrict.PlayerInside(_index - 1);                    
    }    
}
