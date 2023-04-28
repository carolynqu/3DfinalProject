using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSwitcher : MonoBehaviour
{
    public GameObject targetObject;
    public Button colorSwitchButton;

    private Color[] colors = { Color.red, Color.blue, Color.green };
    private int currentColorIndex = 0;

    void Start()
    {
        colorSwitchButton.onClick.AddListener(SwitchColor);
    }

    void SwitchColor()
    {
        currentColorIndex = (currentColorIndex + 1) % colors.Length;
        targetObject.GetComponent<Renderer>().material.color = colors[currentColorIndex];
    }
}