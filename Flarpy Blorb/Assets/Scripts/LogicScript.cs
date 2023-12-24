using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public Text highScore;
    public GameObject gameOverScreen;
    public GameObject scoreTextObject;
    public BirdScript bird;
    public bool birdIsAlive;
    [ContextMenu("Increase Score")]
    void Start() {
        birdIsAlive = true;
    }
    public void addScore(int scoreToAdd) {
        if (birdIsAlive) {
            playerScore += scoreToAdd;
        }
        scoreText.text = playerScore.ToString();
    }
    public void setHighScore()
    {
        highScore.text = "Score: " + playerScore.ToString();
    }
    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void menuScreen(){
        SceneManager.LoadScene(0);
    }

    public void gameOver(){
        gameOverScreen.SetActive(true);
        scoreTextObject.SetActive(false);
    }
}
