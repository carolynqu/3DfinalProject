using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{

    private float timer = 1;


    public GameObject ball;


    public void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {

            Destroy(ball);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {

            Destroy(ball);
        }



        


    }
}
