using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pixel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool blue = false;
        bool black = false;
        bool green = false;
        bool orange = false;
        bool red = false;
        bool white = true;
        bool yellow = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = new Color(0f, 0f, 0f, 1f);
    }
}
