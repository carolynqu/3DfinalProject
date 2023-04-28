using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSwitcher : MonoBehaviour
{
    public GameObject targetObject;

    private Color[] colors = { Color.red, Color.blue, Color.green };
    private int currentColorIndex = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SwitchColor(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SwitchColor(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SwitchColor(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SwitchColor(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SwitchColor(4);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            SwitchColor(5);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            SwitchColor(6);
        }
    }

    void SwitchColor(int index)
    {
        targetObject.GetComponent<Renderer>().material.color = colors[index];
    }
}