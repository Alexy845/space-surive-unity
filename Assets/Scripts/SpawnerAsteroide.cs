using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerAsteroide : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float spawnRate = 1f;
    public float spawnRadius = 20f; 
    public float destroyDelay = 6f; 

    private float nextSpawnTime = 0f;

    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            SpawnAsteroid();
            nextSpawnTime = Time.time + 1f / spawnRate;
        }
    }

    void SpawnAsteroid()
    {
        Vector2 randomSpawnPos = (Vector2)transform.position + Random.insideUnitCircle.normalized * spawnRadius;
        GameObject newAsteroid = Instantiate(asteroidPrefab, randomSpawnPos, Quaternion.identity);

        Destroy(newAsteroid, destroyDelay);
    }
}