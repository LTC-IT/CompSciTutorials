using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class D2Score : MonoBehaviour
{
    private int score;
    private Text D2ScoreText;

    void Start()
    {
        D2ScoreText = GetComponent<Text>();
    }

    public void Update()
    {
        D2ScoreText.text = score.ToString();
    }

    public void AddScore()
        {
            score += 1;
        }
}
