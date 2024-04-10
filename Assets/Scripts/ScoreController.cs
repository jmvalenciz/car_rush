using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text score;
    public static int scoreCount;

    // Update is called once per frame
    void Update() {
        this.score.text = "Score: " + ScoreController.scoreCount;
    }
}
