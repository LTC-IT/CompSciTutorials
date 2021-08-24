/* Logic:

Variable with a starting time (10 seconds)
Function to countdown each second

Function to update the screen based on the timers
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour {

    public int allowedTime = 10;
    private Text textField;
    private int currentTime;

    // Use this for initialization
    void Awake () {
        // set the current time to be the maximum time allowed - "allowedTime"
        currentTime = allowedTime;
        // Connect with GUI Asset
        textField = GetComponent<Text>();
        // Update the GUIText
        UpdateTimerText();  
        // Update timer using a coroutine (mutlithreading)
        StartCoroutine(Tick());
    }
    
    // Update the GUI
    void UpdateTimerText() {
        textField.text = currentTime.ToString();
    }

    IEnumerator Tick() {
        Debug.Log(currentTime);
        while (currentTime > 0) {
            // wait for a second
            yield return new WaitForSeconds(1);
            // reduce currentTime by 1
            currentTime--;
            // Update the screen GUI
            UpdateTimerText();
    }
    yield return new WaitForSeconds(3);
    SceneManager.LoadScene(0);
    }
}

