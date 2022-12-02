using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private float _sceneSwitchDelay = 1f;
    bool _hasEnded = false;
    private string _restartMethod = "Restart";

    public void EndGame()
    {
        if (!_hasEnded)
        {
            _hasEnded = true;            
            Invoke(_restartMethod, _sceneSwitchDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
