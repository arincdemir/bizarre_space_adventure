using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelSpawner : MonoBehaviour
{

    public float expectedSpawnDelay;
    public GameObject fuelPrefab;
    public GameObject boostPrefab;

    float maxX;
    float maxY;
    public float velocityY;

    // Start is called before the first frame update
    void Start()
    {
        maxY = Camera.main.orthographicSize;
        maxX = maxY * Camera.main.aspect;
    }


    void Update()
    {
        // Randomly spawns fuels but on average delay is expectedSpawnDelay.
        float randNum = Random.Range(0f, 1f);
        int boostType = Random.Range(0,3);

        if(Time.deltaTime/expectedSpawnDelay >= randNum)
        {
            switch (boostType)
            {
                case 0:
                    SpawnFuel();
                    break;
                case 1:
                    SpawnFuel();
                    break;
                case 2:
                    SpawnBoost();
                    break;
            }

            
        }
    }

    void SpawnFuel()
    {
        GameObject newFuel = Instantiate(fuelPrefab, new Vector2(transform.position.x + Random.Range(-maxX, maxX), transform.position.y), Quaternion.identity);
        newFuel.GetComponent<Rigidbody2D>().velocity = new Vector2(0, velocityY);
        newFuel.transform.parent = transform;
    }

    void SpawnBoost()
    {
        GameObject newBoost = Instantiate(boostPrefab, new Vector2(transform.position.x + Random.Range(-maxX, maxX), transform.position.y), Quaternion.identity);
        newBoost.GetComponent<Rigidbody2D>().velocity = new Vector2(0, velocityY);
        newBoost.transform.parent = transform;

    }
}
