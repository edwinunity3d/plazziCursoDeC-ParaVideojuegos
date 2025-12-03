using UnityEditor.EditorTools;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
void OnTriggerEnter2D(Collider2D collision) 
{
    GameObject obje = collision.gameObject;
    Debug.Log(obje.gameObject.name);
    if (collision.tag == "Player")
     {
        Debug.Log("Muerte Player");
        PlayerController controller = collision.GetComponent<PlayerController>();
        controller.Die();
    }
}
}
