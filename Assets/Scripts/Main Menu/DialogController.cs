using UnityEngine;
using UnityEngine.SceneManagement; // Pastikan SceneManager ditambahkan

public class PanelController : MonoBehaviour
{
	[Header("Panels in Canvas")]
	[Tooltip("Drag and drop all panels in order here.")]
	public GameObject[] panels; // Array untuk semua panel di canvas

	public string sceneNameToLoad = "GameScene"; // Nama scene yang akan dimuat setelah panel selesai

	private int currentPanelIndex = 0; // Indeks panel yang sedang aktif

	void Start()
	{
		// Inisialisasi: Hanya panel pertama yang aktif
		for (int i = 0; i < panels.Length; i++)
		{
			panels[i].SetActive(i == 0);
		}
	}

	void Update()
	{
		// Pindah ke panel berikutnya dengan klik atau tombol spasi
		if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
		{
			ShowNextPanel();
		}
	}

	public void ShowNextPanel()
	{
		// Sembunyikan panel saat ini
		if (currentPanelIndex < panels.Length)
		{
			panels[currentPanelIndex].SetActive(false);
		}

		// Aktifkan panel berikutnya jika ada
		currentPanelIndex++;
		if (currentPanelIndex < panels.Length)
		{
			panels[currentPanelIndex].SetActive(true);
		}
		else
		{
			// Jika sudah selesai dengan semua panel, pindah ke scene lain
			LoadScene();
		}
	}

	public void SkipToMainPanel()
	{
		// Sembunyikan semua panel dialog
		for (int i = 0; i < panels.Length; i++)
		{
			panels[i].SetActive(false);
		}

		// Langsung pindah ke scene lain
		LoadScene();
	}

	private void LoadScene()
	{
		// Pindah ke scene yang ditentukan
		SceneManager.LoadScene(sceneNameToLoad);
	}
}
