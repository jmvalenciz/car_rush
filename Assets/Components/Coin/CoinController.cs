using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider c){
        if(c.gameObject.tag == "Player"){
            ScoreController.coinCount += 1;
            this.audioSource.Play();
            GetComponent<Collider>().enabled = false;
            GetComponent<MeshRenderer>().enabled = false;
            StartCoroutine(DestroyAfterAudio());
        }
    }
    private IEnumerator DestroyAfterAudio() {
        yield return new WaitForSeconds(audioSource.clip.length);
        Destroy(gameObject);
    }
}