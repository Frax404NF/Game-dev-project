using UnityEngine;
using UnityEngine.SceneManagement;

public class ModePanelController : MonoBehaviour
{
	[Header("Scene Names")]
	[Tooltip("Nama scene yang akan dimuat ketika tombol ditekan.")]
	public string scene1Name = "Hutan"; // Nama scene pertama
	public string scene2Name = "Gurun"; // Nama scene kedua
	public string scene3Name = "Salju"; // Nama scene ketiga

	// Fungsi untuk tombol Mode 1
	public void OnMode1ButtonClicked()
	{
		// Pindah ke scene pertama
		SceneManager.LoadScene(scene1Name);
	}

	// Fungsi untuk tombol Mode 2
	public void OnMode2ButtonClicked()
	{
		// Pindah ke scene kedua
		SceneManager.LoadScene(scene2Name);
	}

	// Fungsi untuk tombol Mode 3
	public void OnMode3ButtonClicked()
	{
		// Pindah ke scene ketiga
		SceneManager.LoadScene(scene3Name);
	}

	// Fungsi untuk tombol Back (Kembali ke Main Menu)
	public void OnBackButtonClicked()
	{
		// Pindah kembali ke main menu atau scene yang sesuai
		SceneManager.LoadScene("MainMenu");
	}
}
