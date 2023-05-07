using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update

    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    public GameObject[] animalPrefabs;
    private float spawnRangeX = 10;
    private float spawPosZ = 20;

    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.S)){
            SpawnRandomAnimal();
        }*/
    }

    void SpawnRandomAnimal()
    {
        // Randomly generate animal index and spawn position
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos,
        animalPrefabs[animalIndex].transform.rotation);
    }
}