using Unity.VisualScripting;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public Canvas menuCanvas;

    public static MenuManager singleton;


    void Awake()
    {
        if(singleton == null)
        {
            singleton = this;
        }
    }

    public void ShowMainMenu()
    {
        menuCanvas.enabled = true;
    }

    public void HideMainMenu()
    {
        menuCanvas.enabled = false;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
       
        #else
         Application.Quit();
       #endif

    }
}
