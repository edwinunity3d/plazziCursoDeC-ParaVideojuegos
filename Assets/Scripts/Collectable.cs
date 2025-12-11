using UnityEngine;


public enum CollectableType
{
    healthPotion,
    manaPotion,
    money
}
public class Collectable : MonoBehaviour
{
    public CollectableType type = CollectableType.money;

    private SpriteRenderer sprite;
    private CircleCollider2D itemCollider;

    bool hasBeenCollected = false;
    public int value = 1;
    private PlayerController player ;
    private AudioSource coinSound;

    void Awake()
    {
        sprite  = GetComponent<SpriteRenderer>();
        itemCollider = GetComponent<CircleCollider2D>();

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        coinSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Show()
    {
        sprite.enabled = true;
        itemCollider.enabled = true;
        hasBeenCollected = false;
    }

    void Hide()
    {
        sprite.enabled = false;
        itemCollider.enabled = false;
        
    }
    void Collect()
    {
        Hide();
        hasBeenCollected = true;

        switch (this.type)
        {
            case CollectableType.money:
            GameManager.singleton.CollectObject(this);
            coinSound.Play();
            
            break;
            case CollectableType.healthPotion:
           
            player.CollectHealth(this.value);
            break;
            case CollectableType.manaPotion:
            
            player.CollectMana(this.value);
            break;
            
        }

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
           Collect();
        }
    }




}
