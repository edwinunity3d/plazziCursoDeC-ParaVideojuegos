using System;
using UnityEngine;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    //variables del movimiento del personaje
    public float runningSpeed = 5;

    //variables del salto del personaje
    public float jumpForce = 6f;

    private Rigidbody2D playerRigidbody;

    public LayerMask groundMask;
    [SerializeField, Range(0,20)] private float distRay =2f;

    private Animator  animator;

    private const string STATE_ALIVE = "isAlive";
    private const string STATE_ON_THE_GROUND = "isOnTheGround";
   
/// <summary>
/// Awake is called when the script instance is being loaded.
/// </summary>
private void Awake()
{
    playerRigidbody = GetComponent<Rigidbody2D>();
    animator = GetComponent<Animator>();
}

    void Start()
    {
        animator.SetBool(STATE_ALIVE, true);
        animator.SetBool(STATE_ON_THE_GROUND, isTouchingTheGround());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
          animator.SetBool(STATE_ON_THE_GROUND, isTouchingTheGround());
        Debug.DrawRay(this.transform.position, Vector3.down * distRay, Color.red  );
      
    }

    void FixedUpdate()
    {
        if (GameManager.singleton.currentGameState == GameState.inGame)
        {
            if(playerRigidbody.linearVelocity.x < runningSpeed)
           {
            playerRigidbody.linearVelocity = new Vector2(runningSpeed, playerRigidbody.linearVelocity.y);
            }
        }
        else
        {
            playerRigidbody.linearVelocity = new Vector2(0,playerRigidbody.linearVelocity.y);
        }
        
      // move();
    }
    void Jump()
    {
        if(GameManager.singleton.currentGameState == GameState.inGame)
        {
            if (isTouchingTheGround())
        {
              playerRigidbody.AddForce(Vector2.up * jumpForce,ForceMode2D.Impulse );
        }
        }
        
  

    }
    bool isTouchingTheGround()
    {
        if(Physics2D.Raycast(this.transform.position,Vector2.down , distRay, groundMask))
        {
           //animator.enabled = true;
         

         
            return true;

            
        }
        else
        {
           // animator.enabled = false;
            return false;
        }
    }

 private void move()
    {
        playerRigidbody.linearVelocity = new Vector2(Input.GetAxis("Horizontal")* runningSpeed , playerRigidbody.linearVelocity.y );
        if(Input.GetAxis("Horizontal")< 0)
        {
            GetComponent<SpriteRenderer>().flipX =true;
        }
        if(Input.GetAxis("Horizontal")> 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
    void OnDrawGizmos()
    {
        
    }

    public void Die()
    {
        this.animator.SetBool(STATE_ALIVE, false);
        GameManager.singleton.GameOver();
    }
}
