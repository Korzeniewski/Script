using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anime : MonoBehaviour {

    private Rigidbody2D mybody;
    public Animator animator;
    public float speed;
    public float junpPower;
    public Collider2D podloga;
    public bool grounded;
    public LayerMask whatIsGround;
    private Collider2D myCollider;
    public bool dbljump = false;
    public bool jumps;
    private bool facingRight;
    public bool cave = false;





    // Use this for initialization
    void Start () {
        mybody = gameObject.GetComponent<Rigidbody2D>();
        myCollider = gameObject.GetComponent<Collider2D>();
        facingRight = true;
    }

    // Update is called once per frame
    void FixedUpdate() {
        //zmienne 
        grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);

        //chodzenie 
        float move = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(move));
        mybody.velocity = new Vector2(move * speed, mybody.velocity.y);
        Flip(move);

        //skakanie

        if (Input.GetKeyDown(KeyCode.Space) && !cave && grounded || Input.GetKeyDown(KeyCode.UpArrow) && !cave && grounded)
        {
            mybody.velocity = Vector2.up * junpPower;
            dbljump = false;
            animator.SetBool("IsJumping", true);
        } else if(Input.GetKeyDown(KeyCode.Space) && cave || Input.GetKeyDown(KeyCode.UpArrow) && cave)
            {
            mybody.gravityScale *= -1;
            transform.Rotate(180 * -1, 0, 0);
        }
    
        
        if (!grounded)
        {
            animator.SetBool("IsJumping", true);
        }
        else
        {
            animator.SetBool("IsJumping", false);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            mybody.gravityScale *= -1;
            transform.Rotate(180 * -1, 0, 0);
        }
    }
    private void Flip(float move)
    {
        if (move >0 && !facingRight || move < 0 && facingRight)
        {
            facingRight = !facingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }
}
