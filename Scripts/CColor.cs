using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CColor : MonoBehaviour
{
    public SpriteRenderer board;
    public Color color1;

    public bool isOn = false;

    public void colorchange() 
    {
        if (isOn == false)
        {
            board.color = color1;
            isOn = true;
        }
        else if (isOn == true)
        {
            board.color = Color.white;
            isOn = false;
 
        }
        
    }
}
