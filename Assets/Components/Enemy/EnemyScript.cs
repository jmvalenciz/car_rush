using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
    private void OnTriggerEnter(Collider c){
        if(c.gameObject.tag == "Player"){
            Destroy(c.gameObject);
        }
    }
}
