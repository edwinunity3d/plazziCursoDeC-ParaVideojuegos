using UnityEngine;

public class ExitZone : MonoBehaviour
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
        if(collision.tag == "Player")
        {
            LevelManager.singleton.AddLeveBlock();
            LevelManager.singleton.RemoveLevelBlock();
        }
    }
}
