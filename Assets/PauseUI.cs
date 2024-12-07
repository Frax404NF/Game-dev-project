using UnityEngine;
using UnityEngine.SceneManagement; // Perlu untuk Scene Management

public class PauseUI : MonoBehaviour
{
    public GameObject pausePanel; // Panel untuk menu pause
    private bool isPaused = false; // Status pause

    // Update is called once per frame
    void Update()
    {
        // Cek tombol ESC untuk toggle pause
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame(); // Jika sudah pause, lanjutkan game
            }
            else
            {
                PauseGame(); // Jika belum pause, hentikan game
            }
        }
    }

    // Fungsi untuk menghentikan game
    public void PauseGame()
    {
        pausePanel.SetActive(true); // Tampilkan panel pause
        Time.timeScale = 0;        // Hentikan waktu
        isPaused = true;           // Perbarui status
    }

    // Fungsi untuk melanjutkan game
    public void ResumeGame()
    {
        pausePanel.SetActive(false); // Sembunyikan panel pause
        Time.timeScale = 1;          // Lanjutkan waktu
        isPaused = false;            // Perbarui status
    }

    // Fungsi untuk kembali ke Main Menu
    public void LoadMainMenu()
    {
        Time.timeScale = 1; // Pastikan waktu berjalan normal
        SceneManager.LoadScene("MainMenu"); // Ganti "MainMenu" dengan nama scene utama Anda
    }
}
