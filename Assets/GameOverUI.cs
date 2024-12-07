using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public void Restart()
    {
        // Mengambil nama scene yang sedang aktif
        string currentSceneName = SceneManager.GetActiveScene().name;

        // Mengatur waktu agar berjalan normal
        Time.timeScale = 1;

        // Memuat ulang scene yang sedang aktif
        SceneManager.LoadScene(currentSceneName);
    }

    public void GoToMainMenu()
    {
        // Memuat scene MainMenu
        SceneManager.LoadScene("MainMenu");
        
    }
}
    