using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class StickPickup : MonoBehaviour
{
    // P R O P E R T I E S

    //public bool HasCoal = false; 
    /// ^^ no longer need this var since the fire gains time when the player picks up the coal <summary>
    ///    the player will just trigger the time increase when the coal gets picked up
    /// </summary>
    
    public int StickStash = 0;


    // break time
    float burnTime = 30; // in seconds
    // stick state
    public bool IsOnFire = false;

    // references
    [SerializeField] GameObject Fire;
    FireBehavior fireBehavior;

    // M E T H O D

    private void Awake()
    {
        fireBehavior = Fire.GetComponent<FireBehavior>();
    }

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
        switch (collision.gameObject.tag)
        {
            case "Stick":
                StickStash++;
                Debug.Log("Stick Collected");
                break;

            case "Coal":
                Debug.Log("Coal Collected");
                if (fireBehavior != null)
                    fireBehavior.OnCoalCollected();
                break;
        }
    }

    /*
     * TD
        Add coal / coal pickup
        Add time when coal is added to fire (whenever coal is picked up, add time to fire) [DONE]
        Update UI when sticks & coal (timer) are collected
     */
}
