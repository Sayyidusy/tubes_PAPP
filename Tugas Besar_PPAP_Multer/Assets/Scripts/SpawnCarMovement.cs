using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCarMovement : MonoBehaviour
{
    public float speed = 10f;
    public float maxX = -400f;

    private void Update()
    {
        MoveCar();
    }

    private void MoveCar()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (transform.position.x <= maxX)
        {
            Destroy(gameObject);
        }
    }
}
