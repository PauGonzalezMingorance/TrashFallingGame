using UnityEngine;
using System.Collections;

public class TrashSpawner : MonoBehaviour
{
    public GameObject trashRedPrefab;
    public GameObject trashYellowPrefab;
    public GameObject trashBluePrefab;
    private ScoreController score;
    public Transform spawnPoint;
    public float spawnDelay = 2f;

    void Start()
    {
        score = FindObjectOfType<ScoreController>();
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            // Dynamically adjust spawn delay based on score
            float currentDelay = score.getScore() >= 3 ? 1.5f : spawnDelay;

            SpawnRandomTrash();
            yield return new WaitForSeconds(currentDelay);
        }
    }

    void SpawnRandomTrash()
    {
        int rand = Random.Range(0, 3);

        GameObject trashToSpawn = rand switch
        {
            0 => trashRedPrefab,
            1 => trashYellowPrefab,
            2 => trashBluePrefab,
            _ => trashRedPrefab
        };

        Vector3 spawnPos = spawnPoint.position;
        spawnPos.y = 1.5f;  // force Y to 1.5
        spawnPos.z = 0f;    // force Z to 0 for 2D plane

        Instantiate(trashToSpawn, spawnPos, Quaternion.identity);
        Debug.Log("Spawned trash color: " + trashToSpawn.name);
    }


}
