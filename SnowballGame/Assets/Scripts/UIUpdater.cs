using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIUpdater : MonoBehaviour
{
    // P R O P E R T I E S

    [Header("UI References")]
    [SerializeField] Text timerDisplay;
    [SerializeField] Image[] HealthDisplay;
    [SerializeField] Text scoreDisplay;

    [Header("Image References")]
    [SerializeField] Sprite litHeart;
    [SerializeField] Sprite exstinguishedHeart;

    [Header("GameObject References")]
    [SerializeField] FireBehavior fireBehavior;
    [SerializeField] StickPickup stickPickup;
    [SerializeField] EnemyManager enemyManager;

    // M E T H O D S
    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerDisplay.text = fireBehavior.timer.CheckTime(Time.time).ToString();
        scoreDisplay.text = enemyManager.Score.ToString();
        HandleHealthDisplay();
    }

    void HandleHealthDisplay()
    {
        int adjustedFireHealth = fireBehavior.Health - 1; //fire health adjusted to work with array
        for (int i = 0; i <= (HealthDisplay.Length - 1); i++) // cycles through all the hearts in the UI
        {
            // check to see if the current heart should be lit or not
            if (i <= adjustedFireHealth) // i
            {
                HealthDisplay[i].sprite = litHeart;
            }
            else if (i > adjustedFireHealth) // if the 
            {
                HealthDisplay[i].sprite = exstinguishedHeart;
            }
        }
    }
}
