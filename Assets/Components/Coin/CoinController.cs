using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class CoinController : MonoBehaviour
{
    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
=======
public class CoinController : MonoBehaviour {
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider c){
        if(c.gameObject.tag == "Player"){
>>>>>>> 8c3794a457e75b9ad0098203e1677028dec83146
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