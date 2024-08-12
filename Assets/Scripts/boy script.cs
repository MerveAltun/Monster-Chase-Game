using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class boyscript : MonoBehaviour
{
    [SerializeField]
    private float moveForce = 10f;
    [SerializeField]
    private float jumpForce = 20f;

    private float movementX;
    //private float movementY;

    private Rigidbody2D myBody;

    private SpriteRenderer sr;

    private Animator anim;
    private string WALK_ANIMATION = "walk";

    private bool isGrounded = true;
    private string GROUND_TAG = "Ground";
    private string ENEMY_TAG = "Enemy";
    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMoveKeyboard();
        AnimatePlayer();
        PlayerJump();


    }
    

    void playerMoveKeyboard()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        //movementY = Input.GetAxisRaw("Vertical");
        // Debug.Log("move X value is: " + movementX );
        //Debug.Log("move Y value is: " + movementY);
        transform.position += new Vector3(movementX, /*movementY*/0f, 0f) * Time.deltaTime * moveForce;
    }

    void AnimatePlayer()
    {
        
        if (movementX > 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            //we are going to the right side
            sr.flipX = false;
        }
        else if (movementX < 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            // we are going to the left side
            sr.flipX = true;
        }
        else
        {
            anim.SetBool(WALK_ANIMATION, false);
            //stop
           
        }
        

    }
    void PlayerJump()
    {
       /* if (Input.GetButtonUp("Jump"))
        {
            Debug.Log("Jump Presssed");
        }*/
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded = false;   
            // Debug.Log("Jump Pressed");
            myBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);

        }
 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(GROUND_TAG))
        {

            isGrounded = true;
            Debug.Log("We landed on Ground");
        }

        if (collision.gameObject.CompareTag(ENEMY_TAG))
        {
            Destroy(gameObject);
        }

        
    }
   /* private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(ENEMY_TAG))
        {
            Destroy(gameObject);
        }
    }*/
}// class

























