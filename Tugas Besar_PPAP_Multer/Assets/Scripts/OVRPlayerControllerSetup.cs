using UnityEngine;

public class OVRPlayerControllerSetup : MonoBehaviour
{
    private OVRPlayerController playerController;

    private void Start()
    {
        playerController = GetComponent<OVRPlayerController>();
    }

    private void Update()
    {
        // Mengatur kecepatan berjalan menggunakan input dari kontroler Oculus Quest
        float moveInput = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).y;
        playerController.SetMoveScaleMultiplier(moveInput);

        // Mengatur kecepatan rotasi menggunakan input dari kontroler Oculus Quest
        float rotateInput = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).x;
        playerController.SetRotationScaleMultiplier(rotateInput);
    }
}
