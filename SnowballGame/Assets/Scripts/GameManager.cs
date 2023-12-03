using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // P R O P E R T I E S
    [SerializeField] bool HasGameEnded = false;
    [SerializeField] float delay;

    [Header("References")]
    [SerializeField] ButtonBehavior btnBehavior;


    // M E T H O D S
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HasGameEnded)
            StartCoroutine(ReactToGameEnd());
    }
    public void EndGame()
    {
        HasGameEnded = true;
    }

    IEnumerator ReactToGameEnd()
    {
        yield return new WaitForSeconds(delay);
        btnBehavior.ShowEndScreen();
    }
}
