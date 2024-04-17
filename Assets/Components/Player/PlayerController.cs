using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField] WheelCollider leftfront_wheel;
    [SerializeField] WheelCollider leftback_wheel;
    [SerializeField] WheelCollider rightfront_wheel;
    [SerializeField] WheelCollider rightback_wheel;

    public float acceleration = 200f;
    public float brake = 600f;

    private float actualBrake = 0f;
    private float actualAccelertion = 0f;

    private float steerAngle = 15;
    private float currentSteerAngle = 0;

    void Start() {
        
    }

    // Update is called once per frame
    void FixedUpdate() {
        if(Input.GetKey(KeyCode.Space)){
            this.actualBrake = this.brake;
            this.actualAccelertion = 0f;
        } else {
            this.actualBrake = 0f;
            this.actualAccelertion = this.acceleration;
        }

        this.currentSteerAngle = this.steerAngle * Input.GetAxis("Horizontal");

        this.leftback_wheel.brakeTorque = this.actualBrake;
        this.rightback_wheel.brakeTorque = this.actualBrake;
        this.rightfront_wheel.motorTorque = this.actualAccelertion;
        this.leftfront_wheel.motorTorque = this.actualAccelertion;

        this.leftfront_wheel.steerAngle = this.currentSteerAngle;
        this.rightfront_wheel.steerAngle = this.currentSteerAngle;
    }
}
