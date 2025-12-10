using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float runningSpeed = 1.5f;
    private Rigidbody2D enemyRigidbody;
    public bool facingRight = false;
     private Vector3 startPosition;
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
}
