using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    // P R O P E R T I E S
    [SerializeField] Transform Fire;
    Rigidbody2D rb2D;
    Animator animator;
    Vector2 targetPosition;

    public bool HasDied = false;
    [SerializeField] float speed;
    [SerializeField] float deathSequenceTimeLength;

    // M E T H O D S
    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        targetPosition = new Vector2(Fire.position.x, Fire.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (HasDied)
            StartCoroutine(SelfDestruct());
    }

    private void FixedUpdate()
    {
        MoveEnemy();
    }
    void MoveEnemy()
    {
        // move toward fire
        Vector2 currentPos = new Vector2(transform.position.x, transform.position.y);
        Vector2 force = (targetPosition - currentPos) * speed;
        rb2D.AddForce(force);

        animator.SetFloat("MoveX", force.x);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            Debug.Log("Enemy hit fire");
            HasDied = true;
            //play death anim   [DONE]
        }
    }

    IEnumerator SelfDestruct()
    {
        rb2D.velocity = Vector2.zero;
        animator.SetBool("HasDied", true);
        yield return new WaitForSeconds(deathSequenceTimeLength);
        Destroy(this.gameObject);

    }

    /* TD
     * stick drop -> dependent on if died by player or not
     * snowman health and damage from player
     * 
     * death method [DONE]
     * 
     */
}
