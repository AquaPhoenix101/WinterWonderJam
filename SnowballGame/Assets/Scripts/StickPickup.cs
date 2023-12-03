using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEditor;
using UnityEngine;

public class StickPickup : MonoBehaviour
{
    // P R O P E R T I E S

    //public bool HasCoal = false; 
    /// ^^ no longer need this var since the fire gains time when the player picks up the coal <summary>
    ///    the player will just trigger the time increase when the coal gets picked up
    /// </summary>
    
    public int StickStash = 0;
    [SerializeField] float attackRadius;


    // break time

    public bool HasActiveStick;
    bool CanAttack = false;

    // references
    [SerializeField] GameObject Fire;
    FireBehavior fireBehavior;
    Animator animator;

    // M E T H O D

    private void Awake()
    {
        fireBehavior = Fire.GetComponent<FireBehavior>();
        animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
            CanAttack = true;
    }
    private void FixedUpdate()
    {
        if (CanAttack)
        {

            Attack();
            

        }
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6) ;
            
    }

    void Attack()
    {       
            Debug.Log("Attacked with burning stick");
        animator.SetTrigger("AttackTest");

            Vector2 position = new Vector2(transform.position.x, transform.position.y);
            Collider2D[] hitColliders = Physics2D.OverlapCircleAll(position, attackRadius);
            animator.SetBool("Attack", true);
            
            foreach (Collider2D hitCollider in  hitColliders)
            {
                if (hitCollider.gameObject.CompareTag("Enemy"))
                {
                    Debug.Log("Hit Enemy!");
                    EnemyBehavior EB = hitCollider.gameObject.GetComponent<EnemyBehavior>();
                    if (EB != null)
                    {
                        EB.HasDied = true;
                        EB.CanSpawnStick = true;
                    }
                        
                }
            }
            
              

        CanAttack = false;
    }

    //void LightStick()
    //{
    //    Debug.Log($"Lit stick! Will burn for {burnTime} seconds");
    //    IsOnFire = true;
    //    StickStash--;
    //    burnTimer.StartTimer(Time.time, burnTime);
    //    Debug.Log($"Timer state: {burnTimer.State.ToString()}");
    //}

    //void HandleSticks()
    //{
    //    // setting active stick bool for attack method
    //    if (IsOnFire)
    //    {
    //        HasActiveStick = true;
    //        animator.SetBool("HasActiveStick", true);
    //    }
    //    else
    //    {
    //        HasActiveStick = false;
    //        animator.SetBool("HasActiveStick", false);
    //    }
        
    //    // handling burn timer
    //    burnTimer.UpdateTimer(Time.time);
    //    switch (burnTimer.State)
    //    {
    //        case TimerState.Started:
    //        case TimerState.Running:
    //            IsOnFire = true;
    //            break;

    //        case TimerState.Ended:
    //            IsOnFire = false;
    //            burnTimer.ResetTimer();
    //            break;
    //    }


    //}

    /*
     * TD
        Add coal / coal pickup [DONE]
        Add time when coal is added to fire (whenever coal is picked up, add time to fire) [DONE]
        Update UI when sticks & coal (timer) are collected [DONE]

        attack [DONE]
     *      damage [DONE]
     *      hitbox [DONE] (the OverlapCircle does this)
     * collect and use powerups
     */
}
