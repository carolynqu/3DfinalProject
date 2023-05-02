using UnityEngine;
using UnityEngine.UI;

public class PowerBar : MonoBehaviour
{
    Image image; // Reference to the Image component on the Canvas
    public Sprite[] sprites; // Array of Sprites to loop through
    private int currentIndex = 0; // Current index of the displayed sprite

    public float loopInterval = 0.5f; // Interval between sprite changes
    private float timer = 0f; // Timer to track the interval

    private bool isLooping = false; // Flag to track if looping is active


    private void Start()
    {
        // Assign the Image component from the same GameObject
        image = GetComponent<Image>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            isLooping = true;
        }
        else
        {
            isLooping = false;
            currentIndex = 1;
            timer = 0f;
            image.sprite = sprites[0];
        }


        if (isLooping)
        {
            timer += Time.deltaTime;
            if (timer >= loopInterval)
            {
                // Time interval reached, move to the next sprite
                timer = 0f;
                currentIndex++;
                if (currentIndex >= sprites.Length)
                {
                    currentIndex = 1; // Loop back to the first sprite
                }
                ShowCurrentSprite();
            }
        }

    }

    private void ShowCurrentSprite()
    {
        // Update the Image component with the current sprite
        image.sprite = sprites[currentIndex];
    }
}