using UnityEngine;
using UnityEngine.XR;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 100f;

    private Rigidbody rb;
    private float movementInput;
    private float rotationInput;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Dapatkan input dari Oculus Quest 2
        movementInput = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).y;
        rotationInput = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).x;
    }

    private void FixedUpdate()
    {
        MoveCar();
        RotateCar();
    }

    private void MoveCar()
    {
        Vector3 movement = transform.forward * movementInput * speed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);
    }

    private void RotateCar()
    {
        Quaternion rotation = Quaternion.Euler(0f, rotationInput * rotationSpeed * Time.deltaTime, 0f);
        rb.MoveRotation(rb.rotation * rotation);
    }
}
