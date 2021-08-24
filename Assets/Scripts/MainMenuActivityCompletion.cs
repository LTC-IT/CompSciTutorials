using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MainMenuActivityCompletion : MonoBehaviour
{
    public GameObject BinaryIntroductionStar;
    public GameObject BinaryConversionStar;
    public static int BinaryIntroduction = 0;
    public static int BinaryConversion = 0;

    // Update is called once per frame
    void Update()
    {
        if(BinaryIntroduction >= 1)
        {
            BinaryIntroductionStar.SetActive(true);
            if(BinaryIntroduction >= 2)
            {
                BinaryIntroduction = 1;
            }
        }
        
        if(BinaryConversion >= 1)
        {
            BinaryConversionStar.SetActive(true);
            if(BinaryConversion >= 2)
            {
                BinaryConversion = 1;
            }
        }
    }
}
