using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ThrowingAction : MonoBehaviour
{

    public Transform camera;
    public Transform attackPoint;
    public GameObject objectToThrow;


    public int totalThrows;
    public float throwCoolDown;

    public KeyCode throwKey = KeyCode.Mouse0;
    public float throwForce;
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
        GameObject projectile = Instantiate(objectToThrow, attackPoint.position, camera.rotation);

        //get rigidbody component
        Rigidbody projectileRB = projectile.GetComponent<Rigidbody>();

        //add force
        Vector3 forceToAdd = camera.transform.forward * throwForce + transform.up * throwUpwardForce;

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
