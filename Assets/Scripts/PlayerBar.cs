using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public enum BarType
{
    healthBar,
    manaBar
}
public class PlayerBar : MonoBehaviour
{
    private Slider slider;
    public BarType type;
    private PlayerController player ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        slider = GetComponent<Slider>();
        switch (type)
        {
            case BarType.healthBar:
            slider.maxValue = PlayerController.MAX_HEALTH;
            break;
            case BarType.manaBar:
            slider.maxValue = PlayerController.MAX_MANA;
            break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (type)
        {
            case BarType.healthBar:
            slider.value = player.GetHealth();
            break;
            case BarType.manaBar:
            slider.value = player.GetMana();
            break;

            
        }
    }
}
