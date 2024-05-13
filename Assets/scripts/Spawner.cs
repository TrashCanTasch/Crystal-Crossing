using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float spawnDelay = .3f;
    float nextTimeToSpawn = 0f;

    public GameObject rock;
    public GameObject rock_flip;

    public Transform[] spawnPoints;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nextTimeToSpawn <= Time.time) {
            SpawnRock();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }

    void SpawnRock() {
        int randIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randIndex];
        if (randIndex < spawnPoints.Length / 2) {
            Instantiate(rock, spawnPoint.position, spawnPoint.rotation);
        } else {
            Instantiate(rock_flip, spawnPoint.position, spawnPoint.rotation);
        }
    }

}
