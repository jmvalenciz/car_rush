using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySoundController : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip enemyWin;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            audioSource.PlayOneShot(enemyWin);
        }
    }
}
