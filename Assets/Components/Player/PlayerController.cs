using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] WheelCollider leftfront_wheel;
    [SerializeField] WheelCollider leftback_wheel;
    [SerializeField] WheelCollider rightfront_wheel;
    [SerializeField] WheelCollider rightback_wheel;

    public float acceleration = 200f;
    public float brake = 600f;

    private float actualBrake = 0f;
    private float actualAccelertion = 0f;

    private float steerAngle = 10;
    private float currentSteerAngle = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        actualBrake = 0f;
        actualAccelertion = 0f;

        if (Input.GetKey(KeyCode.Space))
        {
            this.actualBrake = this.brake;
            this.actualAccelertion = 0f;
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            actualAccelertion = acceleration;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            actualAccelertion = -acceleration;//para retroceder
        }

        /*
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            float verticalInput = Input.GetAxis("Vertical");
            Vector3 movementVector = transform.forward * verticalInput;
            transform.position += movementVector * Time.deltaTime;
        }*/


        this.currentSteerAngle = this.steerAngle * Input.GetAxis("Horizontal");


        this.leftback_wheel.brakeTorque = this.actualBrake;
        this.rightback_wheel.brakeTorque = this.actualBrake;
        this.rightfront_wheel.motorTorque = this.actualAccelertion;
        this.leftfront_wheel.motorTorque = this.actualAccelertion;

        this.leftfront_wheel.steerAngle = this.currentSteerAngle;
        this.rightfront_wheel.steerAngle = this.currentSteerAngle;
    }
}
