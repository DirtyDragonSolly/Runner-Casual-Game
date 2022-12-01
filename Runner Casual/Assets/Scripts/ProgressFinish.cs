using UnityEngine;
using UnityEngine.UI;

public class ProgressFinish : MonoBehaviour
{
    public Transform player;
    public Transform Finish;
    public Text progressInProcents;

    private void Update()
    {
        progressInProcents.text = $"{GetProgressInProcents().ToString("0.0")}%";
    }

    private float GetProgressInProcents()
    {
        return player.position.z / (Finish.position.z / 100);
    }
}
