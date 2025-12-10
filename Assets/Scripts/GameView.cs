using UnityEngine;
using UnityEngine.UI;

public class GameView : MonoBehaviour
{
    public Text cointText, scoreText, maxScoreText;
    private PlayerController player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.singleton.currentGameState == GameState.inGame)
        {
            int coins = GameManager.singleton.collectedObject;
            float score = player.GetTravelledDistance();
            float maxScore = PlayerPrefs.GetFloat("maxscore", 0);


            cointText.text = coins.ToString();
            scoreText.text =  "Score: " + score.ToString("f1");
            maxScoreText.text = "MaxScore; " + maxScore.ToString("f1");
        }
    }



}
