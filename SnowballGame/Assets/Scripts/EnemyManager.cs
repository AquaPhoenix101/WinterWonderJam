using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform spawnGround;
    public float spawnRadius = 10f;
    public float randomness = 2f;
    public int numberOfEnemies = 10;

    void Start()
    {
        if (spawnGround == null)
        {
            Debug.LogError("Spawn ground not assigned to the EnemyManager script.");
            return;
        }

        SpawnEnemies();
    }

    void SpawnEnemies()
    {
        for (int i = 0; i < numberOfEnemies; i++)
        {
            Vector3 randomPosition = GetRandomSpawnPosition();
            Instantiate(enemyPrefab, randomPosition, Quaternion.identity, transform);
        }
    }

    Vector3 GetRandomSpawnPosition()
    {
        Vector2 randomCircle = Random.insideUnitCircle * spawnRadius * randomness;
        Vector3 randomPosition = new Vector3(randomCircle.x, randomCircle.y, 0f);
        return spawnGround.position + randomPosition;
    }
}
