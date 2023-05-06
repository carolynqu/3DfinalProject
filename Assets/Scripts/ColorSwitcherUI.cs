using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSwitcherUI : MonoBehaviour
{
    Image image; // Reference to the Image component on the Canvas
    public Sprite[] sprites; // Array of Sprites to loop through

    private void Start()
    {
        // Assign the Image component from the same GameObject
        image = GetComponent<Image>();
    }

    void Update()
    {

        //display the correct sprite depending on what color is present
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            image.sprite = sprites[0];
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            image.sprite = sprites[1];
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            image.sprite = sprites[2];
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            image.sprite = sprites[3];
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            image.sprite = sprites[4];
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            image.sprite = sprites[5];
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            image.sprite = sprites[6];

        }
    }
}
