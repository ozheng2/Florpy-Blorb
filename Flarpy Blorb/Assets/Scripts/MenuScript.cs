using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void onPlayButton(){
        SceneManager.LoadScene(1);
    }
    
    public void onQuitButton(){
        Application.Quit();
    }
}
