using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
    public bool IsGamePaused = false;
    public GameObject pauseMenuUI;

    void Start(){
        pauseMenuUI.SetActive(false);
    }
    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(IsGamePaused){
                Resume();
            } else {
                Pause();
            }
        }
    }

    public void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        IsGamePaused = false;
    }

    public void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        IsGamePaused = true;
    }

    public void GoToMenu(){
        Time.timeScale = 1f;
        IsGamePaused = false;
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
