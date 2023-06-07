using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{


    public float baseSpawnDelay;
    public float velocityY;
    public float velocityYFluctuation;
    public float maxVelocityX;
    public float gameTimeToDelayTimeMult;

    public GameObject asteroidPrefab;
    public GameObject asteroidPrefab1;
    public GameObject asteroidPrefab2;
    public GameObject asteroidPrefab3;
    public GameObject asteroidPrefab4;
    public GameObject asteroidPrefab5;
    public GameObject asteroidPrefab6;
    public GameObject asteroidPrefab7;

    float timeWaited;
    public float spawnDelay;
    float maxX;
    float maxY;
    float secondCounter = 0;

    float boostMultipler;

    void Start()
    {
        timeWaited = 0;
        spawnDelay = baseSpawnDelay;
        maxY = Camera.main.orthographicSize;
        maxX = maxY * Camera.main.aspect;
    }

    void Update()
    {
        boostMultipler = BackgroundVariables.instance.multipler;

        timeWaited += Time.deltaTime;
        if(timeWaited > spawnDelay)
        {
            timeWaited -= spawnDelay;
            spawnAsteroid();
            if(Random.Range(0,2) == 0)
            {
                spawnAsteroid();
            }
        }

        secondCounter += Time.deltaTime;
        if (secondCounter > 1)
        {
            SpeedUpSpawner();
            secondCounter -= 1;
        }
    }

    void spawnAsteroid()
    {
        GameObject chosenAsteroid;
        int randNum = Random.Range(0, 8);
        switch (randNum)
        {
            case 0:
                chosenAsteroid = asteroidPrefab1;
                break;

            case 1:
                chosenAsteroid = asteroidPrefab2;
                break;
            case 2:
                chosenAsteroid = asteroidPrefab3;
                break;
            case 3:
                chosenAsteroid = asteroidPrefab4;
                break;
            case 4:
                chosenAsteroid = asteroidPrefab5;
                break;
            case 5:
                chosenAsteroid = asteroidPrefab6;
                break;
            case 6:
                chosenAsteroid = asteroidPrefab7;
                break;
            default:
                chosenAsteroid = asteroidPrefab;
                break;
        }

        float randX = Random.Range(-maxX, maxX);
        float randXVel = Random.Range(-maxVelocityX, maxVelocityX);
        float randYVel = velocityY + Random.Range(-velocityYFluctuation, velocityYFluctuation);
        GameObject newAsteroid = Instantiate(chosenAsteroid, new Vector2(transform.position.x + randX, transform.position.y), Quaternion.identity);
        newAsteroid.GetComponent<Rigidbody2D>().velocity = new Vector2(randXVel, randYVel);
        newAsteroid.transform.parent = transform;
    }

    void SpeedUpSpawner()
    {
        spawnDelay *= (gameTimeToDelayTimeMult);
    }

}
