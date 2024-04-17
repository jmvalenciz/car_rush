using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text score;
    public Text coins;
    public static int scoreCount;
    public static int coinCount;

    // Update is called once per frame
    void Update() {
        this.score.text = "Score: " + ScoreController.scoreCount;
        this.coins.text = "Coins: " + ScoreController.coinCount;
    }
}
