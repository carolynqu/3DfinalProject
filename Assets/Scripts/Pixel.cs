using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pixel : MonoBehaviour
{
    public GameObject ballObject;
    public Material[] BlockColors;
    private Material currentColor;
    // Start is called before the first frame update
    void Start()
    {
        currentColor = BlockColors[5];
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<MeshRenderer>().material.name.Contains("Black"))
        {
            currentColor = BlockColors[0];
        }
        if (collision.gameObject.GetComponent<MeshRenderer>().material.name.Contains("Blue"))
        {
            currentColor = BlockColors[1];
        }
        if (collision.gameObject.GetComponent<MeshRenderer>().material.name.Contains("Green"))
        {
            currentColor = BlockColors[2];
        }
        if (collision.gameObject.GetComponent<MeshRenderer>().material.name.Contains("Orange"))
        {
            currentColor = BlockColors[3];
        }
        if (collision.gameObject.GetComponent<MeshRenderer>().material.name.Contains("Red"))
        {
            currentColor = BlockColors[4];
        }
        if (collision.gameObject.GetComponent<MeshRenderer>().material.name.Contains("White"))
        {
            currentColor = BlockColors[5];
        }
        if (collision.gameObject.GetComponent<MeshRenderer>().material.name.Contains("Yellow"))
        {
            currentColor = BlockColors[6];

        }
        GetComponent<Renderer>().material = currentColor;
    }
}
