using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class ScriptableObjects : MonoBehaviour
{
    public int value;

    public void UpdateValue(int number)
    {
        value += number;
    }

    public void ReplaceValue(int number)
    {
        value = number;  
    }
    public void DisplayImage(Image img)
    {
        img.fillAmount = value; 
    }

    public void DisplayNumber(Text txt)
    {
        txt.text = value.ToString();
    }
    

}
