using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSwitcher : MonoBehaviour
{
    public GameObject targetObject;
    private Renderer obj;

    //booleans for colors
    public static bool blue = false;
    public static bool black = false;
    public static bool green = false;
    public static bool orange = false;
    public static bool red = false;
    public static bool white = false;
    public static bool yellow = false;

    public Material [] colors;

    
    private Material currentColor;

    private void Start()
    {
        obj = targetObject.GetComponent<Renderer>();
        currentColor = colors[0];
    }

    void Update()
    {
        //check what key is down and changing the r
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentColor = colors[0];
            ResetBool();
            black = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentColor = colors[1];
            ResetBool();
            blue = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentColor = colors[2];
            ResetBool();
            green = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            currentColor = colors[3];
            ResetBool();
            orange = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            currentColor = colors[4];
            ResetBool();
            red = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            currentColor = colors[5];
            ResetBool();
            white = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            currentColor = colors[6];
            ResetBool();
            yellow = true;

        }
        obj.material = currentColor;
    }


    //caled to reset the colors to all be false
    //except the one we want to be true
    void ResetBool()
    {
        blue = false;
        black = false;
        green = false;
        orange = false;
        red = false;
        white = false;
        yellow = false;
    }
}