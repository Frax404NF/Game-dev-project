using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    public float laneWidth = 2.0f; // Jarak antar jalur
    public float moveSpeed = 5.0f; // Kecepatan perpindahan jalur

    private int currentLane; // Posisi awal (0: kiri, 1: tengah, 2: kanan)
    private Vector3 targetPosition; // Posisi target untuk perpindahan

    void Start()
    {
        // Set posisi awal
        targetPosition = transform.position;
    }

    void Update()
    {
        HandleInput();
        MovePlayer();
    }

    // Menghandle input untuk perpindahan jalur
    void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            MoveLeft();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            MoveRight();
        }
    }

    // Fungsi untuk bergerak ke kiri
    void MoveLeft()
    {
        if (currentLane > -1) // Cek jika tidak berada di jalur paling kiri
        {
            currentLane--;
            targetPosition = new Vector3(transform.position.x, transform.position.y, currentLane * laneWidth);
        }
    }

    // Fungsi untuk bergerak ke kanan
    void MoveRight()
    {
        if (currentLane < 1) // Cek jika tidak berada di jalur paling kanan
        {
            currentLane++;
            targetPosition = new Vector3(transform.position.x, transform.position.y, currentLane * laneWidth);
        }
    }

    // Memindahkan pemain ke posisi target
    void MovePlayer()
    {
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * moveSpeed);
    }
}
