using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateController : MonoBehaviour {
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider c){
        if(c.gameObject.tag == "Player"){
            ScoreController.scoreCount += 1;
            this.audioSource.Play();
            GetComponent<Collider>().enabled = false;
            transform.GetChild(0).gameObject.SetActive(false);
            StartCoroutine(DestroyAfterAudio());
        }
    }
    private IEnumerator DestroyAfterAudio() {
        yield return new WaitForSeconds(audioSource.clip.length);
        Destroy(gameObject);
    }
}
