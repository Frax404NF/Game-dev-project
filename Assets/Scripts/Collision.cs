using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    public Score score;
    public GameObject gameOver;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
            Time.timeScale = 0;
            gameOver.SetActive(true);
        }
        else if (other.tag == "SampahOrganic")
        {
            score.ScorePlusOneOrg();
            Destroy(other.gameObject);
        }
        else if (other.tag == "SampahUnorganic")
        {
            score.ScorePlusOneUnorg();
            Destroy(other.gameObject);
        }
    }
}
