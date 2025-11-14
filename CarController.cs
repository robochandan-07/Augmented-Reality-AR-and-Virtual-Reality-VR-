using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public WheelCollider FrontRightWheelCollider;
    public WheelCollider BackRightWheelCollider;
    public WheelCollider FrontLeftWheelCollider;
    public WheelCollider BackLeftWheelCollider;
    public Transform FrontRightWheelTransform;
    public Transform BackRightWheelTransform;
    public Transform FrontLeftWheelTransform;
    public Transform BackLeftWheelTransform;
    public Transform CarCentreofMassTransform;
    public Rigidbody rigidbody;
    public float motorForce = 100f;
    public float steeringAngle = 30f;
    public float breakForce = 1000f;

    float VerticalInput;
    float HorizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody.centerOfMass = CarCentreofMassTransform.localPosition;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MotorForce();
        UpdateWheels();
        GetInput();
        Steering();
        ApplyBrakes();
        PowerSteering();
    }
    void GetInput()
    {
        VerticalInput = Input.GetAxis("Vertical");
        HorizontalInput = Input.GetAxis("Horizontal");
    }
    void ApplyBrakes()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            FrontRightWheelCollider.brakeTorque =breakForce;
            BackRightWheelCollider.brakeTorque = breakForce;
            FrontLeftWheelCollider.brakeTorque = breakForce;
            BackLeftWheelCollider.brakeTorque = breakForce;
            rigidbody.drag = 1f;
        }
        else
        {
            FrontRightWheelCollider.brakeTorque = 0f;
            BackRightWheelCollider.brakeTorque = 0f;
            FrontLeftWheelCollider.brakeTorque = 0f;
            BackLeftWheelCollider.brakeTorque = 0f;
            rigidbody.drag = 0f;
        }
        
    }
    void MotorForce()
    {
        FrontRightWheelCollider.motorTorque = motorForce * VerticalInput;
        FrontLeftWheelCollider.motorTorque = motorForce * VerticalInput;
    }
    void Steering()
    {
        FrontRightWheelCollider.steerAngle = steeringAngle * HorizontalInput;
        FrontLeftWheelCollider.steerAngle = steeringAngle * HorizontalInput;
    }
    void PowerSteering()
    {
        if (HorizontalInput == 0)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime);
        }
    }
    void UpdateWheels()
    {
        RotateWheel(FrontLeftWheelCollider, FrontLeftWheelTransform);
        RotateWheel(BackLeftWheelCollider, BackLeftWheelTransform);
        RotateWheel(FrontRightWheelCollider, FrontRightWheelTransform);
        RotateWheel(BackRightWheelCollider, BackRightWheelTransform);
    }
    void RotateWheel(WheelCollider wheelcollider,Transform transform)
    {
        Vector3 pos;
        Quaternion rot;
        wheelcollider.GetWorldPose(out pos, out rot);
        transform.position = pos;
        transform.rotation = rot;
    }
}
