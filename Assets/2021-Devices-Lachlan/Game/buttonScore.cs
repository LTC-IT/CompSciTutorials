using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonScore : MonoBehaviour
{
    public int score;

    public void AddScore()
    {
        score += 1;
    }
}
