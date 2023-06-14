using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StirController : MonoBehaviour
{// Transform dari bodi mobil
    public float rotationSpeed = 100f; // Kecepatan rotasi stir

    private float maxWheelRotation = 180f; // Maksimum rotasi stir dalam derajat

    private void Update()
    {
        // Dapatkan input rotasi mobil
        float rotationInput = Input.GetAxis("Horizontal");

        // Hitung rotasi stir berdasarkan input rotasi mobil
        float wheelRotation = rotationInput * maxWheelRotation;

        // Rotasi stir
        transform.localRotation = Quaternion.Euler(0f, 0f, -wheelRotation);
//
        // Rotasi bodi mobil berdasarkan input rotasi mobil
        Quaternion carRotation = Quaternion.Euler(0f, rotationInput * rotationSpeed * Time.deltaTime, 0f);
    }
}