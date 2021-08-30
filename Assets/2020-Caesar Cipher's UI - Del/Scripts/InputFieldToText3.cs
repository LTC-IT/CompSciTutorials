using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldToText3 : MonoBehaviour {
    public InputField clearText;
     public InputField cipherText;
 
public static char cipher(char ch, int key) {  
            if (!char.IsLetter(ch)) {  
  
                return ch;  
            }  
  
            char d = char.IsUpper(ch) ? 'A' : 'a';  
            return (char)((((ch + key) - d) % 26) + d);  
  
  
        }  
  
  
        public static string Encipher(string input, int key) {  
            string output = string.Empty;  
  
            foreach(char ch in input)  
            output += cipher(ch, key);  
  
            return output;  
        }  

     public void CopyText() {

         cipherText.text = Encipher(clearText.text, 2);

         //TextBox.text = Field.text;
     }

public void DecyptText() {
    int key = 2;

     clearText.text= Encipher(cipherText.text, 26 - key);  
}



 }
