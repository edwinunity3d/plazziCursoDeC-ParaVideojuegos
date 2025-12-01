using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //variables del movimiento del personaje
    public float speed = 5;

    //variables del salto del personaje
    public float jumpForce = 6f;

    private Rigidbody2D playerRigidbody;
   
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
        if (Input.GetKey(KeyCode.Space)||  Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    void Jump()
    {
        playerRigidbody.AddForce(Vector2.up * jumpForce,ForceMode2D.Impulse );

    }
}
