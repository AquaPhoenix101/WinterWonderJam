using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class FireBehavior : MonoBehaviour
{
    // P R O P E R T I E S
    public int Health = 3;
    public Timer timer;
    [SerializeField] float timeLenght = 60;

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
        HandleTimer();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            if (Health != 0)
            {
                Health--;
                Debug.Log($"Fire hit! Health = {Health}");
            }
        }

        // if collision is player nad player has coal
            //reset timer
    }

    public void OnCoalCollected() // to be called when the player picks up coal
    {
        timer.ResetTimer();
        timer.StartTimer(Time.time, timeLenght);
    }

    void HandleTimer()
    {
        switch (timer.State)
        {
            case TimerState.Started:
            case TimerState.Running:
                timer.UpdateTimer(Time.time);
                break;

            case TimerState.Ended:
                // end game
                Debug.Log("The fire has burned out, you lose");
                break;
        }
    }
    
    /* TD
     * react loss health
     * react to timer end
     * update the ui -> timer, health
     * 
     * add time when given coal [DONE]
     */

}
