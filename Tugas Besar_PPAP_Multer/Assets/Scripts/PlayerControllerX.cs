using UnityEngine;
using UnityEngine.XR;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 100f;

    private Rigidbody rb;
    private float rightControllerVerticalInput;  // Input vertikal dari controller kanan
    private float leftControllerHorizontalInput;  // Input horizontal dari controller kiri

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Dapatkan input dari Oculus Quest 2
        rightControllerVerticalInput = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).y;
        leftControllerHorizontalInput = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).x;
    }

    private void FixedUpdate()
    {
        MoveCar();
        RotateCar();
    }

    private void MoveCar()
    {
        Vector3 movement = transform.forward * rightControllerVerticalInput * speed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);
    }

    private void RotateCar()
    {
        Quaternion rotation = Quaternion.Euler(0f, leftControllerHorizontalInput * rotationSpeed * Time.deltaTime, 0f);
        rb.MoveRotation(rb.rotation * rotation);
    }
}
