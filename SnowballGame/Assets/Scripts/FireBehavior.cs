using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class FireBehavior : MonoBehaviour
{
    // P R O P E R T I E S
    public int Health = 3;
    Timer timer;
    float timeLenght = 120;

    // M E T H O D S
    private void Awake()
    {
        timer = new Timer();
    }
    // Start is called before the first frame update
    void Start()
    {
        timer.StartTimer(Time.time, timeLenght);
    }

    // Update is called once per frame
    void Update()
    {
        timer.UpdateTimer(Time.time);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            if (Health != 0)
            {
                Health--;
                Debug.Log("Fire hit!");
            }
        }

        // if collision is player nad player has coal
            //reset timer
    }
    
    /* TD
     * react loss health
     * react to timer end
     * update the ui -> timer, health
     * 
     * add time when given coal
     */

}
