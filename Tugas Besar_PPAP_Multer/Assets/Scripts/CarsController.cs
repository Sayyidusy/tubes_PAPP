using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsController : MonoBehaviour
{
    public float Acceleration { get; private set; }
    public float Steering { get; private set; }

    private bool accelerating = false;
    private bool breaking = false;
    private bool turningLeft = false;
    private bool turningRight = false;

    public float wheelDampening;

    private void Update()
    {
        GetPlayerInput();

        if (accelerating)
        {
            Acceleration = 1f;
            wheelDampening = 500f;
        }
        else if (breaking)
        {
            Acceleration = -1f;
            wheelDampening = 500f;
        }
        else
        {
            Acceleration = 0f;
            wheelDampening = 5f;
        }

        if (turningLeft)
        {
            Steering = -1f;
        }
        else if (turningRight)
        {
            Steering = 1f;
        }
        else
        {
            Steering = 0f;
        }
    }

    private void GetPlayerInput()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryThumbstickUp))
        {
            accelerating = true;
        }
        else if (OVRInput.GetUp(OVRInput.Button.PrimaryThumbstickUp))
        {
            accelerating = false;
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryThumbstickDown))
        {
            breaking = true;
        }
        else if (OVRInput.GetUp(OVRInput.Button.PrimaryThumbstickDown))
        {
            breaking = false;
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryThumbstickLeft))
        {
            turningLeft = true;
        }
        else if (OVRInput.GetUp(OVRInput.Button.PrimaryThumbstickLeft))
        {
            turningLeft = false;
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryThumbstickRight))
        {
            turningRight = true;
        }
        else if (OVRInput.GetUp(OVRInput.Button.PrimaryThumbstickRight))
        {
            turningRight = false;
        }
    }
}
