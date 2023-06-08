using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public BirdScript bird;
    public bool birdIsAlive;
    [ContextMenu("Increase Score")]
    void Start(){
        birdIsAlive = true;
    }
    public void addScore(int scoreToAdd){
        if(birdIsAlive){
            playerScore = playerScore + scoreToAdd;
        }
        scoreText.text = playerScore.ToString();
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver(){
        gameOverScreen.SetActive(true);
    }
}
