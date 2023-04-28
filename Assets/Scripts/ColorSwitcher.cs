using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSwitcher : MonoBehaviour
{
    public GameObject targetObject;
    private Renderer obj;
    //black = new Color(0, 0, 0);
    //blue = new Color(5, 172, 255);
    //green = new Color(67, 255, 38);
    //orange = new Color(255, 149, 0);
    //red = new Color(255, 38, 38);
    //white = new Color (255, 255, 255);
    //yellow = new Color (255, 210, 31);
    public static bool blue = false;
    public static bool black = false;
    public static bool green = false;
    public static bool orange = false;
    public static bool red = false;
    public static bool white = false;
    public static bool yellow = false;

    public Material [] colors;

    private int currentColorIndex = 0;
    private Material currentColor;
    private void Start()
    {
        obj = targetObject.GetComponent<Renderer>();
        currentColor = colors[0];
    }
    void Update()
    {
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