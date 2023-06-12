using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 100f;

    public AudioClip moveSoundClip;
    public AudioClip reverseSoundClip;
    public AudioClip turnSoundClip;

    private Rigidbody rb;
    private float movementInput;
    private float rotationInput;
    public AudioSource audioSource;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        movementInput = Input.GetAxis("Vertical");
        rotationInput = Input.GetAxis("Horizontal");

        PlayMovementSound();
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

    private void PlayMovementSound()
    {
        if (movementInput > 0f)
        {
            if (!audioSource.isPlaying || audioSource.clip != moveSoundClip)
            {
                audioSource.clip = moveSoundClip;
                audioSource.Play();
            }
        }
        else if (movementInput < 0f)
        {
            if (!audioSource.isPlaying || audioSource.clip != reverseSoundClip)
            {
                audioSource.clip = reverseSoundClip;
                audioSource.Play();
            }
        }
        else
        {
            audioSource.Stop();
        }
    }

    private void PlayTurnSound()
    {
        if (Mathf.Abs(rotationInput) > 0f)
        {
            if (!audioSource.isPlaying || audioSource.clip != turnSoundClip)
            {
                audioSource.clip = turnSoundClip;
                audioSource.Play();
            }
        }
        else
        {
            audioSource.Stop();
        }
    }
}