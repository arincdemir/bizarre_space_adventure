using UnityEngine;

public class PlanetSpawner : MonoBehaviour
{
    public float spawnDelay;
    public float velocityY;
    float BoostMultipler = 1f;

    public GameObject planetPrefab1;
    public GameObject planetPrefab2;
    public GameObject planetPrefab3;
    public GameObject planetPrefab4;
    public GameObject planetPrefab5;
    public GameObject planetPrefab6;
    public GameObject planetPrefab7;
    public GameObject planetPrefab8;
    public GameObject planetPrefab9;
    public GameObject planetPrefab10;
    public GameObject planetPrefab11;
    public GameObject planetPrefab12;
    public GameObject planetPrefab13;
    public GameObject planetPrefab14;
    public GameObject planetPrefab15;
    public GameObject planetPrefab16;
    public GameObject planetPrefab17;
    public GameObject planetPrefab18;
    public GameObject planetPrefab19;
    public GameObject planetPrefab20;
    public GameObject planetPrefab21;
    public GameObject planetPrefab22;
    public GameObject planetPrefab23;
    public GameObject planetPrefab24;
    public GameObject planetPrefab25;
    public GameObject planetPrefab26;
    public GameObject planetPrefab27;
    public GameObject planetPrefab28;
    public GameObject planetPrefab29;
    public GameObject planetPrefab30;
    public GameObject planetPrefab31;
    public GameObject planetPrefab32;
    public GameObject planetPrefab33;
    public GameObject planetPrefab34;
    public GameObject planetPrefab35;
    

    float timeWaited;
    float maxX;

    void Start()
    {
        timeWaited = spawnDelay;
        maxX = Camera.main.orthographicSize * Camera.main.aspect;
    }

    void Update()
    {
        //BoostMultipler = BackgroundVariables.instance.multipler;
        //GameObject.FindGameObjectWithTag("Planet").GetComponent<Rigidbody2D>().velocity = new Vector2(0, velocityY * BoostMultipler);


        timeWaited += Time.deltaTime;
        if (timeWaited > spawnDelay)
        {
            timeWaited -= spawnDelay;
            spawnPlanet();
        }
    }

    void spawnPlanet()
    {
        GameObject chosenPlanet;
        int randNum = Random.Range(0, 34);
        switch (randNum)
        {
            case 0:
                chosenPlanet = planetPrefab1;
                break;
            case 1:
                chosenPlanet = planetPrefab2;
                break;
            case 2:
                chosenPlanet = planetPrefab3;
                break;
            case 3:
                chosenPlanet = planetPrefab4;
                break;
            case 4:
                chosenPlanet = planetPrefab5;
                break;
            case 5:
                chosenPlanet = planetPrefab6;
                break;
            case 6:
                chosenPlanet = planetPrefab7;
                break;
            case 7:
                chosenPlanet = planetPrefab8;
                break;
            case 8:
                chosenPlanet = planetPrefab9;
                break;
            case 9:
                chosenPlanet = planetPrefab10;
                break;
            case 10:
                chosenPlanet = planetPrefab11;
                break;
            case 11:
                chosenPlanet = planetPrefab12;
                break;
            case 12:
                chosenPlanet = planetPrefab13;
                break;
            case 13:
                chosenPlanet = planetPrefab14;
                break;
            case 14:
                chosenPlanet = planetPrefab15;
                break;
            case 15:
                chosenPlanet = planetPrefab16;
                break;
            case 16:
                chosenPlanet = planetPrefab17;
                break;
            case 17:
                chosenPlanet = planetPrefab18;
                break;
            case 18:
                chosenPlanet = planetPrefab19;
                break;
            case 19:
                chosenPlanet = planetPrefab20;
                break;
            case 20:
                chosenPlanet = planetPrefab21;
                break;
            case 21:
                chosenPlanet = planetPrefab22;
                break;
            case 22:
                chosenPlanet = planetPrefab23;
                break;
            case 23:
                chosenPlanet = planetPrefab24;
                break;
            case 24:
                chosenPlanet = planetPrefab25;
                break;
            case 25:
                chosenPlanet = planetPrefab26;
                break;
            case 26:
                chosenPlanet = planetPrefab27;
                break;
            case 27:
                chosenPlanet = planetPrefab28;
                break;
            case 28:
                chosenPlanet = planetPrefab29;
                break;
            case 29:
                chosenPlanet = planetPrefab30;
                break;
            case 30:
                chosenPlanet = planetPrefab31;
                break;
            case 31:
                chosenPlanet = planetPrefab32;
                break;
            case 32:
                chosenPlanet = planetPrefab33;
                break;
            case 33:
                chosenPlanet = planetPrefab34;
                break;
            default:
                chosenPlanet = planetPrefab35;
                break;
            
        }

        float randX = Random.Range(-maxX, maxX);

        GameObject newAsteroid = Instantiate(chosenPlanet, new Vector2(transform.position.x + randX, transform.position.y), Quaternion.identity);
        newAsteroid.GetComponent<Rigidbody2D>().velocity = new Vector2(0, velocityY * BoostMultipler);
        newAsteroid.transform.parent = transform;
    }

}