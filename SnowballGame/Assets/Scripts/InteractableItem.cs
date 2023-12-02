using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItem : MonoBehaviour
{
    // P R O P E R T I E S


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
        Add time when coal is added to fire
     */

}
