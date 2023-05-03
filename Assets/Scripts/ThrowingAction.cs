using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ThrowingAction : MonoBehaviour
{

    public Transform cam;
    public Transform attackPoint;
    public GameObject objectToThrow;


    public int totalThrows;
    public float throwCoolDown;

    public KeyCode throwKey = KeyCode.Mouse0;
    public float throwSpeed;
    public float throwUpwardForce;

    bool readyToThrow;




    // Start is called before the first frame update
    void Start()
    {
        readyToThrow = true;
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(throwKey) && readyToThrow && totalThrows > 0)
        {
            Throw();
        }
    }




    private void Throw()
    {
        //instatiate object to throw 
        GameObject projectile = Instantiate(objectToThrow, attackPoint.position, cam.rotation);

        //get rigidbody component
        Rigidbody projectileRB = projectile.GetComponent<Rigidbody>();

        //calculate the direction
        Vector3 forceDirection = cam.transform.forward;

        RaycastHit hit;

        if(Physics.Raycast(cam.position, cam.forward, out hit , 500f))
        {
            forceDirection = (hit.point - attackPoint.position).normalized;
        }

        //add force
        Vector3 forceToAdd = forceDirection * throwSpeed + transform.up ;

        projectileRB.AddForce(forceToAdd, ForceMode.Impulse);

        totalThrows--;

        //implement throw cooldown
        Invoke(nameof(ResetThrows), throwCoolDown);




    }


    private void ResetThrows()
    {
        readyToThrow = true;
    }
   }
