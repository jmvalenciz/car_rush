using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateController : MonoBehaviour
{
    private void OnTriggerEnter(Collider c){
        if(c.gameObject.tag == "Player"){
            ScoreController.scoreCount += 1;
            Destroy(gameObject);
        }
    }
}
