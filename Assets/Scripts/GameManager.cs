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
    public GameState currentGameState = GameState.menu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void StartGame()
    {
        
    }


    public void GameOver()
    {
        
    }


    public void BackToMenu()
    {
        
    }

  private void SetGameState(GameState newGameState)
    {
        if(newGameState == GameState.menu)
        {
            
        }else if(newGameState == GameState.inGame)
        {
            
        }
        else if(newGameState == GameState.gameOver)
        {
            
        }

        this.currentGameState = newGameState;
    }

}
