using UnityEngine;
using UnityEngine.SceneManagement;

public class MainPanelController : MonoBehaviour
{
    [Header("Panels in Canvas")]
    public GameObject mainPanel;     // Panel utama yang berisi tombol Play, Tutorial, Exit
    public GameObject modePanel;     // Panel Mode yang akan muncul ketika Play ditekan
    public GameObject tutorialPanel; // Panel Tutorial yang akan muncul ketika Tutorial ditekan

    [Header("Scene Names")]
    [Tooltip("Nama scene yang akan dimuat ketika tombol ditekan.")]
	public string scene1Name = "Hutan"; // Nama scene pertama
	public string scene2Name = "Gurun"; // Nama scene kedua
	public string scene3Name = "Salju"; // Nama scene ketiga
	void Start()
    {
        // Pastikan semua panel dimulai dalam keadaan yang benar
        mainPanel.SetActive(true);
        modePanel.SetActive(false);
        tutorialPanel.SetActive(false);
    }

    // Fungsi untuk tombol Play
    public void OnPlayButtonClicked()
    {
        // Sembunyikan panel utama dan tampilkan panel Mode
        mainPanel.SetActive(false);
        modePanel.SetActive(true);
    }

    // Fungsi untuk tombol Tutorial
    public void OnTutorialButtonClicked()
    {
        // Sembunyikan panel utama dan tampilkan panel Tutorial
        mainPanel.SetActive(false);
        tutorialPanel.SetActive(true);
    }

    // Fungsi untuk tombol Exit
    public void OnExitButtonClicked()
    {
        // Keluar dari aplikasi
        Application.Quit();
        Debug.Log("Exit game"); // Untuk debug (di editor tidak akan keluar)
    }

    // Fungsi untuk tombol Back di panel Mode
    public void OnBackFromModeClicked()
    {
        // Sembunyikan panel Mode dan tampilkan panel utama
        modePanel.SetActive(false);
        mainPanel.SetActive(true);
    }

    // Fungsi untuk tombol Back di panel Tutorial
    public void OnBackFromTutorialClicked()
    {
        // Sembunyikan panel Tutorial dan tampilkan panel utama
        tutorialPanel.SetActive(false);
        mainPanel.SetActive(true);
    }

    // Fungsi untuk tombol Mode 1
    public void OnMode1ButtonClicked()
    {
        // Pindah ke scene pertama
        SceneManager.LoadScene(scene1Name);
    }

    // Fungsi untuk tombol Mode 2
    public void OnMode2ButtonClicked()
    {
        // Mengatur waktu agar berjalan normal
        Time.timeScale = 1;
        // Pindah ke scene kedua
        SceneManager.LoadScene(scene2Name);
    }

    // Fungsi untuk tombol Mode 3
    public void OnMode3ButtonClicked()
    {
        // Pindah ke scene ketiga
        SceneManager.LoadScene(scene3Name);
    }
}
