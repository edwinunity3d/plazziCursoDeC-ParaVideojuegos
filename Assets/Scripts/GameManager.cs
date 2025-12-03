using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public enum GameState
{
    menu, 
    inGame, 
    gameOver
}

public class GameManager : MonoBehaviour
{
    public static GameManager singleton;
    public GameState currentGameState = GameState.menu;

    private PlayerController controller;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    private void Awake()
    {
        if(singleton == null)
        {
            singleton =  this;
        }
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetButtonDown("Submit") &&  currentGameState != GameState.inGame)
        {
            StartGame();
        }
    }


    public void StartGame()
    {
        SetGameState(GameState.inGame);

    }


    public void GameOver()
    {
        SetGameState(GameState.gameOver);
    }


    public void BackToMenu()
    {
        SetGameState(GameState.menu);
    }

  private void SetGameState(GameState newGameState)
    {
        if(newGameState == GameState.menu)
        {
            
        }else if(newGameState == GameState.inGame)
        {
            controller.StartGame();
        }
        else if(newGameState == GameState.gameOver)
        {
            
        }

        this.currentGameState = newGameState;
    }

}
