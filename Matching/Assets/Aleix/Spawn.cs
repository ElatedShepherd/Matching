using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawn : MonoBehaviour
{
	public GameObject[] Symbols; //an array to hold all of the prefabs of symbols we want to spawn
	private bool[] symbolStates = new bool [3];
	public Transform[] spawnPoints; // this array will hold a reference to all the spawn points in the scene
	private bool[] spawnPointState = new bool[3];
    

	public float countSpawnTimer;
	public float spawnTimer = 10;

	void Start() {
		Random.seed = (int)System.DateTime.Now.Ticks;
		countSpawnTimer = spawnTimer;
        ClearArrays();
        Debug.Log(symbolStates[0]);
	}

	void Update() {
		countSpawnTimer -= Time.deltaTime;

		if (countSpawnTimer <= 0){
			countSpawnTimer = 0;
			SpawnSymbols ();			
		}
	}

	void SpawnSymbols (){
		int s;
		int p;

		for (int i=0;i<3;i++){
            do
            {
                s = Random.Range(0, 2);
                Debug.Log(symbolStates[s]);
            }
            while (symbolStates[s]);
            symbolStates[s] = true;
            Debug.Log("primer while");

            do
                p = Random.Range(0, 2);
            while (spawnPointState[p]);
            spawnPointState[p] = true;
            Debug.Log("segundo while");


            GameObject symbol =  Instantiate(Symbols[s], spawnPoints[p].position, spawnPoints[p].rotation) as GameObject;
		}

		ClearArrays();
		countSpawnTimer = spawnTimer;
	}

	void ClearArrays (){
		symbolStates[0] = false;
		symbolStates[1] = false;
		symbolStates[2] = false;
		spawnPointState[0] = false;
		spawnPointState[1] = false;
		spawnPointState[2] = false;

	}
}