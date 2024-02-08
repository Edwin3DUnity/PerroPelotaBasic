using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    private int indexBall;

    [SerializeField, Range(-21, 8)] float spawnLimitXLeft = -21;
    [SerializeField, Range(8, -20)] float spawnLimitXRight = 8;
    private float spawnPosY = 28;

    [SerializeField, Range(0.1f, 5)] float startDelay = 1.0f;
    [SerializeField, Range(0.1f, 5)] float spawnInterval = 5;


    //private float counter = 0;

  //  private float nextWaitTime = 5;
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    private void Update()
    {
     //   SpawnRandomBall();
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        indexBall = Random.Range(0, ballPrefabs.Length);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        Instantiate(ballPrefabs[indexBall], spawnPos, ballPrefabs[indexBall].transform.rotation);
     /*  counter += Time.deltaTime;
        if (counter >= nextWaitTime)
        {
            Instantiate(ballPrefabs[indexBall], spawnPos, ballPrefabs[indexBall].transform.rotation);
            counter = 0;
            nextWaitTime = Random.Range(2, 5);
            Debug.Log(nextWaitTime);
        }
        // instantiate ball at random spawn location
     */

     spawnInterval = Random.Range(2, 5);
    }

}
