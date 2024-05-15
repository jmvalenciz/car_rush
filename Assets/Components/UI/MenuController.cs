using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {
    public void LoadScene(String sceneName){
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
	}
}
