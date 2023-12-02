using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class StickPickup : MonoBehaviour
{
    // P R O P E R T I E S
    public bool HasCoal = false;
    public int StickStash = 0;


    // break time
    float burnTime = 30; // in seconds
    // stick state
    public bool IsOnFire = false;

    // M E T H O D
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Stick"))
        {            
           Debug.Log("Stick Collected");           
        }
    }

    /*
     * TD
        Add coal / coal pickup
        Add time when coal is added to fire (whenever coal is picked up, add time to fire)
        Update UI when sticks & coal (timer) are collected
     */
}
