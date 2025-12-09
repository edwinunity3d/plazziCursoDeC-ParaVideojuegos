using Unity.VisualScripting;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public Canvas menuCanvas;
    public Canvas gameCanvas;
    public Canvas gameOverCanvas;

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
    public void ShowCanvasGame()
    {
        gameCanvas.enabled = true;
        Debug.Log("se activa en canvas del juego");
    }
    public void HideCanvasGame()
    {
        gameCanvas.enabled = false;
    }

    public void ShowCanvasGameOver()
    {
        gameOverCanvas.enabled = true;

    }

    public void HidecanvasGameOver()
    {
        gameOverCanvas.enabled = false;
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
