using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileColorChanger : MonoBehaviour
{

    public GameObject projectile;

    public Material wood1;
    public Material wood2;


    public Material look;

    // Start is called before the first frame update
    void Start()
    {
        look = projectile.GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            look = wood1;
        }


        if (Input.GetKeyDown(KeyCode.S))
        {
            look = wood1;
        }


    }
}
