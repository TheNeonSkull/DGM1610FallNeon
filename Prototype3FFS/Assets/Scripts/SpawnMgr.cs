using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMgr : MonoBehaviour
{
    public GameObject[] enemyPrefabs; 
    private float spawnRangeX = 10;
    private float spawnPosZ = 0;
    private float startDelay = 1;
    public float repeatRate = 1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawnenemy", startDelay, repeatRate);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawnenemy()
    {
        
            //Rando generate enemy and pos
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0, spawnPosZ);
            int enemyIndex = Random.Range(0, enemyPrefabs.Length);
            Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
    

    }
}
