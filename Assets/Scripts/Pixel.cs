using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pixel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (ColorSwitcher.black)
        {
           
        }
        if (ColorSwitcher.blue)
        {
            
        }
        if (ColorSwitcher.green)
        {
           
        }
        if (ColorSwitcher.orange)
        {
            
        }
        if (ColorSwitcher.red)
        {
            
        }
        if (ColorSwitcher.white)
        {
            
        }
        if (ColorSwitcher.yellow)
        {
            

        }
        GetComponent<MeshRenderer>().material.color = new Color(0f, 0f, 0f, 1f);
    }
}
