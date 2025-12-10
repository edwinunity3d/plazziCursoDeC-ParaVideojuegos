using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float runningSpeed = 1.5f;
    private Rigidbody2D enemyRigidbody;
    public bool facingRight = false;
     private Vector3 startPosition;
     public int daño = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        enemyRigidbody = GetComponent<Rigidbody2D>();
        startPosition = this.transform.position;
    }    
    void Start()
    {
        this.transform.position = startPosition;
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        float currentRunningSpeed = runningSpeed;
        if (facingRight)
        {
            currentRunningSpeed = runningSpeed;
            this.transform.eulerAngles = new Vector3(0,180, 0);
        }
        else
        {
            currentRunningSpeed = - runningSpeed;
            this.transform.eulerAngles = Vector3.zero;
        }

        if(GameManager.singleton.currentGameState == GameState.inGame)
        {
            enemyRigidbody.linearVelocity = new Vector2(currentRunningSpeed , enemyRigidbody.linearVelocity.y);
        }
        else
        {
            enemyRigidbody.linearVelocity = new Vector2(0, enemyRigidbody.linearVelocity.y);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coin")
         {
          return;   
        }
      
        if(collision.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerController>().CollectHealth(-daño);
            return;
        }
        facingRight = !facingRight;

    }
}
