using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    private int scoreOrg;
    private int scoreUnorg;
    
    public TextMeshProUGUI ScoreTextOrg;
    public TextMeshProUGUI ScoreTextUnorg;

    public void ScorePlusOneOrg()
    {
        scoreOrg++;
    }

    public void ScorePlusOneUnorg() 
    {
        scoreUnorg++;
    }

    private void Update()
    {
        ScoreTextOrg.text = "Organic :" + scoreOrg.ToString();
        ScoreTextUnorg.text = "Unorganic :" + scoreUnorg.ToString();
    }
}
