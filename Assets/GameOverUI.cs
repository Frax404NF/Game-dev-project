using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public void Restart() 
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Hutan");
    }
}
