using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    void Start() {}

    // Update is called once per frame
    void Update() {
       transform.position = player.transform.position + new Vector3(0, 10, -10); 
       transform.rotation = Quaternion.Euler(45, 0, 0); 
    }
}
