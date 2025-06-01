using UnityEngine;

public class SpawnerMenu : MonoBehaviour
{
    public GameObject[] fallingTrash;
    public float SpawnInterval;
    public Transform canvasTransform;
    private int timer = 0;
    public int timerEnd;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       InvokeRepeating("SpawnTrash",0, SpawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer == timerEnd)
        {
            SpawnTrash();
            timer = 0;
        }
        else
        {
            timer++;
        }
        
    }

    void SpawnTrash()
    {
        int objectIndex = Random.Range(0, fallingTrash.Length);
        GameObject newGameObject = Instantiate(fallingTrash[objectIndex], new Vector3(Random.Range(-922, 922),550,0), fallingTrash[objectIndex].transform.rotation);
        newGameObject.transform.SetParent(canvasTransform, false);
    }
}
