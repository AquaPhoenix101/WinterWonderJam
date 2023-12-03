using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickBehavior : MonoBehaviour //and coal behavior
{
    // P R O P E R T I E S

    

    // M E T H O D S
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            SelfDestruct();
    }
    void SelfDestruct()
    {
        Destroy(this.gameObject);
    }
}
