using UnityEngine;
using UnityEngine.UI;

public class GameView : MonoBehaviour
{
    public Text cointText, scoreText, maxScoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.singleton.currentGameState == GameState.inGame)
        {
            int coins = 0;
            float score = 0;
            float maxScore = 0;


            cointText.text = coins.ToString();
            scoreText.text =  "Score: " + score.ToString("f1");
            maxScoreText.text = "MaxScore; " + maxScore.ToString("f1");
        }
    }



}
