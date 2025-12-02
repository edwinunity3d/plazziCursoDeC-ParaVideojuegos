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

    private const string STATE_ALIVE = "isalive";
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
        if (Input.GetKeyDown(KeyCode.Space)||  Input.GetMouseButtonDown(0))
        {
            Jump();
        }
          animator.SetBool(STATE_ON_THE_GROUND, isTouchingTheGround());
        Debug.DrawRay(this.transform.position, Vector3.down * distRay, Color.red  );
      
    }

    void FixedUpdate()
    {
        if(playerRigidbody.linearVelocity.x < runningSpeed)
        {
            playerRigidbody.linearVelocity = new Vector2(runningSpeed, playerRigidbody.linearVelocity.y);
        }
    }
    void Jump()
    {
        if (isTouchingTheGround())
        {
              playerRigidbody.AddForce(Vector2.up * jumpForce,ForceMode2D.Impulse );
        }
  

    }
    bool isTouchingTheGround()
    {
        if(Physics2D.Raycast(this.transform.position,Vector2.down , distRay, groundMask))
        {
           //animator.enabled = true;
           Debug.Log("Está tocando el piso");
            return true;

            
        }
        else
        {
           // animator.enabled = false;
            return false;
        }
    }

    void OnDrawGizmos()
    {
        
    }
}
