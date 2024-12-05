using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
	public void StartGame()
	{
		// Pindah ke scene permainan utama
		SceneManager.LoadScene("GameScene");
	}

	public void OpenTutorial()
	{
		// Pindah ke scene tutorial
		SceneManager.LoadScene("TutorialScene");
	}

	public void ExitGame()
	{
		// Keluar dari aplikasi
		Application.Quit();
	}
}
