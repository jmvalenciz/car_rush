using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip colectCoin;
    [SerializeField] private AudioClip colectCrate;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Coin")
        {
            audioSource.PlayOneShot(colectCoin);
        }
        if (c.gameObject.tag == "Crate")
        {
            audioSource.PlayOneShot(colectCrate);
        }
    }
}
