using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] carPrefabs;
    public float minSpawnZ = 5f;
    public float maxSpawnZ = 15f;
    public float spawnInterval = 2f;

    private void Start()
    {
        StartCoroutine(SpawnCars());
    }

    private IEnumerator SpawnCars()
    {
        while (true)
        {
            float randomZ = Random.Range(minSpawnZ, maxSpawnZ);
            float poY = 69.76447f; // Y position
            float poX = -209.22f; // X position

            Vector3 spawnPosition = new Vector3(poX, poY, randomZ);
            Quaternion spawnRotation = Quaternion.Euler(0f, -90f, 0f);

            int randomIndex = Random.Range(0, carPrefabs.Length);
            GameObject car = Instantiate(carPrefabs[randomIndex], spawnPosition, spawnRotation);

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
