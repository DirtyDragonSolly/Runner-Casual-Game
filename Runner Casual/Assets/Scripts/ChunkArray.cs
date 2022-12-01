using UnityEngine;

public class ChunkArray : MonoBehaviour
{
    public GameObject[] chunks;
    public ChunkArray[] neighboursChunkArrays;
    
    public void PlayerInside(int index)
    {        
        OffNeighbours();

        OffChunks();

        SetActiveChunks(index);

        SetAcriveNeighbours(index);

        OffNeighborNeigbours();
    }

    void OffChunks()
    {
        foreach (var chunk in chunks)
            chunk.SetActive(false);        
    }
    void OffNeighbours()
    {
        foreach(var chunkArray in neighboursChunkArrays)
        {
            foreach(var chunk in chunkArray.chunks)
            {
                chunk.SetActive(false);
            }
        }
    }
    void SetActiveChunks(int index)
    {
        if(index >= 2 && index <= chunks.Length - 3)
        {
            for(int i = index - 2; i <= index + 2; i++)
                chunks[i].SetActive(true);
        }
        
        else if(index < 2)
            for(int i = 0; i <= index + 2; i++)
                chunks[i].SetActive(true);

        else
            for(int i = index - 2; i < chunks.Length; i++)
                chunks[i].SetActive(true);
    }
    void SetAcriveNeighbours(int index)
    {
        foreach(var chunksNeighbor in neighboursChunkArrays)
        {
            if (index >= 2 && index <= chunksNeighbor.chunks.Length - 3)
            {
                for (int i = index - 2; i <= index + 2; i++)
                    chunksNeighbor.chunks[i].SetActive(true);
            }

            else if (index < 2)
                for (int i = 0; i <= index + 2; i++)
                    chunksNeighbor.chunks[i].SetActive(true);

            else
                for (int i = index - 2; i < chunksNeighbor.chunks.Length; i++)
                    chunksNeighbor.chunks[i].SetActive(true);
        }
    }

    void OffNeighborNeigbours()
    {
        if (neighboursChunkArrays.Length > 1 && neighboursChunkArrays[0].neighboursChunkArrays.Length > 1)
                neighboursChunkArrays[0].neighboursChunkArrays[0].gameObject.SetActive(false);
    }
}
