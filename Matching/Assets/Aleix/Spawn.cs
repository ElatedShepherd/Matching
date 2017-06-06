using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawn : MonoBehaviour
{
    public GameObject[] Symbols; //an array to hold all of the prefabs of symbols we want to spawn
    public Transform[] spawnPoints; // this array will hold a reference to all the spawn points in the scene

    public float countSpawnTimer;
    public float spawnTimer = 10;

    void Start()
    {
        Random.seed = (int)System.DateTime.Now.Ticks;
        countSpawnTimer = spawnTimer;
    }

    void Update()
    {
        countSpawnTimer -= Time.deltaTime;

        if (countSpawnTimer <= 0)
        {
            countSpawnTimer = 0;
            SpawnSymbols();
        }
    }

    void SpawnSymbols()
    {
        int p = Random.Range(0, 3);
        int p2;
        int p3;
        do
            p2 = Random.Range(0, 3);
        while (p2 == p);

        do
            p3 = Random.Range(0, 3);
        while (p3 == p2 || p3 == p);

        GameObject clone = Instantiate(Symbols[0], spawnPoints[p].position, spawnPoints[p].rotation) as GameObject;
        GameObject clone1 = Instantiate(Symbols[1], spawnPoints[p2].position, spawnPoints[p2].rotation) as GameObject;
        GameObject clone2 = Instantiate(Symbols[2], spawnPoints[p3].position, spawnPoints[p3].rotation) as GameObject;

        countSpawnTimer = spawnTimer;
    }
}