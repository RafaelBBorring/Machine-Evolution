using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Buton_Manager : MonoBehaviour
{
    

    public void GameScene()
    {
        SceneManager.LoadScene("Game");
    }
    public void OptionsScene()
    {
        
    }
    
    public void GoMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Pause()
    {
        GameManager.instance.PauseGame();
    }
}
