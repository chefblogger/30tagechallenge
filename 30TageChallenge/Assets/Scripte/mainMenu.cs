using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{

private int LevelID = 0;


    public void PlayGame(){
    SceneManager.LoadScene("Level01");   
    }


    public void QuitGame(){
        Application.Quit();
    }

    public void ResetGame(){
        PlayerPrefs.SetInt("CashPoints", 0 );
    }
}
