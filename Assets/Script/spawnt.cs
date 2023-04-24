using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnt : MonoBehaviour
{
    public GameObject[] enemyPrefabs; // array of enemy prefabs to spawn

    [SerializeField] float minX;
    [SerializeField] float maxX;
    [SerializeField] float spawnY;

    public float spawnInterval = 2f; // time interval between spawning enemies

    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            // choose random enemy prefab and spawn position
            int prefabIndex = Random.Range(0, enemyPrefabs.Length);
            float spawnX = Random.Range(minX, maxX);
            Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0f);

            // instantiate enemy at spawn position
            GameObject enemy = Instantiate(enemyPrefabs[prefabIndex], spawnPosition, Quaternion.identity);

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
