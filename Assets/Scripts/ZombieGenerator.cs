using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieGenerator : MonoBehaviour
{
    public GameObject zombiePrefab;

    int generateCounter = 600;
    int actualCounter = 0;

    public GameObject[] spawnPoints;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(actualCounter >= generateCounter)
        {
            GenerateZombie();
            actualCounter = 0;
        }
        actualCounter++;

    }

    void GenerateZombie()
    {
        Instantiate(zombiePrefab, spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position, Quaternion.identity);
    }
}
