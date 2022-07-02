using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstacle;
    public Transform spawnPosition;
    public float startTime, repeatTime, minPos, maxPos;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacles", startTime, repeatTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnObstacles()
    {
        Vector3 spawnPos = new Vector3(Random.Range(minPos, maxPos), spawnPosition.position.y, spawnPosition.position.z);
        Instantiate(obstacle, spawnPos, spawnPosition.rotation);
    }
}
