using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // P R O P E R T I E S
    public float moveSpeed = 5f;
    Animator animator;

    // M E T H O D S
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        // Get input from the horizontal and vertical axes
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement vector
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f) * moveSpeed * Time.deltaTime;

        // Move the player
        transform.Translate(movement);

        //animations
        animator.SetFloat("MoveX", horizontalInput);
        animator.SetFloat("MoveY", verticalInput);

        // Optional: Flip the player sprite based on horizontal movement direction
        if (horizontalInput < 0)
        {
            // If moving left, flip the sprite
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (horizontalInput > 0)
        {
            // If moving right, reset the sprite scale
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    /* TD
     * 
     * 
     */
}
