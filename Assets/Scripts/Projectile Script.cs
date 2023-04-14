using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject ball;

    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {

            Destroy(ball);
        }
    }
}
