using UnityEngine;

public class PauseUI : MonoBehaviour
{
    public GameObject pause;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            pause.SetActive(true);
        }
    }
}
