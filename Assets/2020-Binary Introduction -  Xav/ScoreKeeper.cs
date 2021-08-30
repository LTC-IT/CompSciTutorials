using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public Text Score;
    public Text Highscore;
    public static int points = 0;
    public static int Correct = 0;
    public static int Incorrect =0;
    public static int Highscorepoints =0;
 
    // Use this for initialization
    void Start () {
   
        Score.text = "";
        Highscore.text = "";
 
    }
 
 
    // Update is called once per frame
    void Update () {
   
        Score.text = "" + points;
        Highscore.text = "" + Highscorepoints;

        //sets highscore points equal to the current value of points when points is greater then or equal to highscore points
        if (points >= Highscorepoints)
        {
            
            Highscorepoints = points;
            Debug.Log("Highscore has been beaten!");
        }
 
    }
 
    //when the player presses the answer that is correct this function is called
    public void CorrectAnswer () {
 
        points ++;
        Correct ++;
    }
   
    //when the player presses the answer that is incorrect this function is called
    public void InorrectAnswer () {
 
        Incorrect ++;
 
    }

    //when the player presses the restart button this function is called
    public void resetscore(){

        points=0;
        Correct=0;
        Incorrect=0;

    }

    public void BinaryIntroductionCompletion()
    {
        if(Highscorepoints >= 8)
        {
        MainMenuActivityCompletion.BinaryIntroduction++; 
        }
        else
        {
            Debug.Log("Player hasn't Earned Enough Points");
        }
    }

    
}
