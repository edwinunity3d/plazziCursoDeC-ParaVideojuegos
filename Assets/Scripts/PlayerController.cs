using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //variables del movimiento del personaje
    public float speed = 5;

    //variables del salto del personaje
    public float jumpForce = 6f;

    private Rigidbody2D playerRigidbody;

    public LayerMask groundMask;
    [SerializeField, Range(0,20)] private float distRay =2f;
   
/// <summary>
/// Awake is called when the script instance is being loaded.
/// </summary>
private void Awake()
{
    playerRigidbody = GetComponent<Rigidbody2D>();
}

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)||  Input.GetMouseButtonDown(0))
        {
            Jump();
        }

        Debug.DrawRay(this.transform.position, Vector3.down * distRay, Color.red  );
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
        if(Physics2D.Raycast(this.transform.position,Vector2.down * distRay, groundMask))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void OnDrawGizmos()
    {
        
    }
}
