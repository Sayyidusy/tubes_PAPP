using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    public Transform PlayerController; // Transform dari objek yang ingin diikuti
    public float smoothness = 5f; // Kelembutan pergerakan objek
    private void Update()
    {
        // Dapatkan posisi yang diinginkan untuk objek mengikuti pemain
        Vector3 targetPosition = PlayerController.position;
        // Interpolasi ke posisi yang diinginkan dengan kelembutan tertentu
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothness * Time.deltaTime);
    }
}