using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamerRespawn : MonoBehaviour
{
    public float Threshold;  //Y-axis
    public Vector3 respawnPoint= new Vector3(0,0,0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.y < Threshold)
        {
            transform.position = respawnPoint;
            transform.rotation = Quaternion.Euler(0,0,0);
        }
    }
}
