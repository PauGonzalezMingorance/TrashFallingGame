using UnityEngine;
using System.Collections;

public class TrashSpawner : MonoBehaviour
{
    public GameObject[] trashRedPrefabs;
    public GameObject[] trashYellowPrefabs;
    public GameObject[] trashBluePrefabs;
    public GameObject[] trashGreenPrefabs;
    public GameObject[] trashGreyPrefabs;
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
        int rand = Random.Range(0, 4);
        Vector3 spawnPos = spawnPoint.position;
        spawnPos.y = 3.5f;  // force Y to 3.5
        spawnPos.z = 0f;    // force Z to 0 for 2D plane

        if(rand == 0)
        {
             int objectIndex = Random.Range(0, trashRedPrefabs.Length);
             Instantiate(trashRedPrefabs[objectIndex], spawnPos, Quaternion.identity);
             Debug.Log("Spawned trash color: " + trashRedPrefabs[objectIndex].name);             
        }
        if(rand == 1)
        {
            int objectIndex = Random.Range(0, trashYellowPrefabs.Length);
            Instantiate(trashYellowPrefabs[objectIndex], spawnPos, Quaternion.identity);
            Debug.Log("Spawned trash color: " + trashYellowPrefabs[objectIndex].name);   
        }
        if(rand == 2)
        {
            int objectIndex = Random.Range(0, trashBluePrefabs.Length);
            Instantiate(trashBluePrefabs[objectIndex], spawnPos, Quaternion.identity);
            Debug.Log("Spawned trash color: " + trashBluePrefabs[objectIndex].name);   
        }
        if(rand == 3)
        {
            int objectIndex = Random.Range(0, trashGreenPrefabs.Length);
            Instantiate(trashGreenPrefabs[objectIndex], spawnPos, Quaternion.identity);
            Debug.Log("Spawned trash color: " + trashGreenPrefabs[objectIndex].name);   
        }
        if(rand == 4)
        {
            int objectIndex = Random.Range(0, trashGreyPrefabs.Length);
            Instantiate(trashGreyPrefabs[objectIndex], spawnPos, Quaternion.identity);
            Debug.Log("Spawned trash color: " + trashGreyPrefabs[objectIndex].name);   
        }
    }
}
