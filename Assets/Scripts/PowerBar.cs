using UnityEngine;
using UnityEngine.UI;

public class PowerBar : MonoBehaviour
{
    //public SpriteRenderer[] sprites; // Array of SpriteRenderers to loop through

    public Image[] images; // Array of Images to loop through
    public Sprite[] sprites; // Array of Sprites to assign to the Images

    private int currentIndex = 0; // Current index of the displayed sprite

    private bool isTabHeld = false; // Flag to track if Tab button is held down

    public float loopInterval = 0.5f; // Interval between sprite changes
    private float timer = 0f; // Timer to track the interval

    private void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            if (!isTabHeld)
            {
                // Tab button pressed down
                isTabHeld = true;
                currentIndex = 0; // Reset the index to the first sprite
                ShowCurrentSprite();
            }

            timer += Time.deltaTime;
            if (timer >= loopInterval)
            {
                // Time interval reached, move to the next sprite
                timer = 0f;
                currentIndex++;
                if (currentIndex >= sprites.Length)
                {
                    currentIndex = 0; // Loop back to the first sprite
                }
                ShowCurrentSprite();
            }
        }
        else
        {
            if (isTabHeld)
            {
                // Tab button released
                isTabHeld = false;
            }
            timer = 0f;
        }
    }

    private void ShowCurrentSprite()
    {
         for (int i = 0; i < images.Length; i++)
        {
            images[i].sprite = sprites[currentIndex];
        }
        //// Hide all sprites except the current one
        //for (int i = 0; i < sprites.Length; i++)
        //{
        //    if (i == currentIndex)
        //    {
        //        sprites[i].gameObject.SetActive(true);
        //    }
        //    else
        //    {
        //        sprites[i].gameObject.SetActive(false);
        //    }
        //}
    }
}