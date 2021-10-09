using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class Points : MonoBehaviour 
{

 
   private Text textfield;
 
   void Awake() {
       textfield = GameObject.Find("Canvas/scoreText").GetComponent<Text>();
   }
//Points will take the form of a number displayed on the canvas. An image of a star will hopefully give it more significance.
   void OnTriggerEnter (Collider collisionInfo) {
       if (collisionInfo.gameObject.tag == "points") {
           Debug.Log("Got a star!");
           Destroy(collisionInfo.gameObject);
           //commonValues.points++;
           //textfield.text = commonValues.points.ToString();
           //if (commonValues.points >=3) {
                   //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
           } // end of if
       } // end of if
    // end of function
} // end of class
