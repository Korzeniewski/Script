using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class heroControl : MonoBehaviour
{
    private Rigidbody2D mybody;
    public Rigidbody2D enemyBody;
    public float speed;
    private bool facingRight;
    private bool facingUp;

    void Start()
    {
        mybody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var move = Input.GetAxis("Horizontal");
        var moveV = Input.GetAxis("Vertical");
        Flip(move);

        mybody.velocity = new Vector2((move)*-1 * speed, (moveV)*-1*speed);
       
    }
    private void Flip(float move)
    {
        if (move > 0 && !facingRight || move < 0 && facingRight)
        {
            facingRight = !facingRight;
            transform.Rotate(0, 0, (180)*-1);
        }
    }
   
}
