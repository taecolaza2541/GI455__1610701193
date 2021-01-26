using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Apply : MonoBehaviour
{
    public Text text;
    public InputField Inputtext;
    private string box;

    public void buttons()
    {
        switch (box)
        {
            case "Line":
                text.text = box + " is found ";
                break;
            case "IG":
                text.text = box + " is found ";
                break;
            case "Facebook":
                text.text = box + " is found ";
                break;
            case "Tinder":
                text.text = box + " is found ";
                break;
            case "Twitter":
                text.text = box + " is found ";
                break;
            default:
                text.text = box + " is not found ";
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
            box = Inputtext.text; 
                }
}
