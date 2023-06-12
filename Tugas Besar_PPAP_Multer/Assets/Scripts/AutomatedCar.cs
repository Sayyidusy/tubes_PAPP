using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomatedCar : MonoBehaviour{

    public float forwardSpeed = 10f;
    public float boundaryX = -387.37f;

    private float initialX;

    private void Start()
    {
        initialX = transform.position.x;
    }

    private void Update()
    {
        MoveCar();
    }

    private void MoveCar()
    {
        float forwardMovement = forwardSpeed * Time.deltaTime;
        transform.Translate(Vector3.forward * forwardMovement);

        if (transform.position.x >= boundaryX)
        {
            Destroy(this.gameObject);
        }
    }
}





