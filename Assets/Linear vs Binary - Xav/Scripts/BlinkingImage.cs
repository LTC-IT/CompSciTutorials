     using UnityEngine;
     using System.Collections;
     using UnityEngine.UI;
     
     public class BlinkingImage : MonoBehaviour {
     
         Image image;
     
         void Start ()
         {
             image = GetComponent<Image>();
             StartBlinking();
         }
     
     
         IEnumerator Blink()
         {
             while (true)
             {
                 switch(image.color.a.ToString())
                 {
                     case "0":
                         image.color = new Color(image.color.r, image.color.g, image.color.b, 1);
                         yield return new WaitForSeconds(0.2f);
                         break;
                     case "1":
                         image.color = new Color(image.color.r, image.color.g, image.color.b, 0);
                         yield return new WaitForSeconds(0.2f);
                         break;
                 }
             }
         }
     
         void StartBlinking()
         {
             StopAllCoroutines();
             StartCoroutine("Blink");
         }
     
         void StopBlinking()
         {
             StopAllCoroutines();
         }
         
     }
     
