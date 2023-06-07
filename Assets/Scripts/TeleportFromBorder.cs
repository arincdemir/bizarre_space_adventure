using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using UnityEngine;

public class TeleportFromBorder : MonoBehaviour
{
    public float radius;
    float maxX;
    float spawnX;
    public GameObject spaceshipPrefab;

    private Rigidbody2D rb;

    public static bool twoShipsExist = false;
    public static GameObject[] spaceships = new GameObject[2];

    /**
    float timeSinceInstantiation = 100;
    public float bondDuration = 0.1f;
    float xSign = 1;
    **/
   
    void Start()
    {
        gameObject.name = "Spaceship";
        maxX = Camera.main.orthographicSize * Camera.main.aspect - radius;
        spawnX = -(maxX + radius * 2);
        spaceships[1] = gameObject;
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (twoShipsExist)
        {
            twoShipsCheck();
        }
        else
        {
            oneShipCheck();
        }
        /**
        if(spaceships[0] != null && spaceships[1] != null && timeSinceInstantiation < bondDuration)
        {
            BondShips();
        }
        **/
    }

    void oneShipCheck()
    {
        if (transform.position.x >= maxX)
        {
            GameObject newShip = Instantiate(spaceshipPrefab, new Vector2(spawnX, transform.position.y), Quaternion.identity);
            newShip.GetComponent<Rigidbody2D>().velocity = rb.velocity;
            spaceships[0] = gameObject;
            twoShipsExist = true;
            //timeSinceInstantiation = 0;
            //xSign = -1;
        }
        else if (transform.position.x <= -maxX)
        {
            GameObject newShip = Instantiate(spaceshipPrefab, new Vector2(-spawnX, transform.position.y), Quaternion.identity);
            newShip.GetComponent<Rigidbody2D>().velocity = rb.velocity;
            spaceships[0] = gameObject;
            twoShipsExist = true;
            //timeSinceInstantiation = 0;
            //xSign = 1;
        }
    }

    void twoShipsCheck()
    {
        if (-maxX < transform.position.x && transform.position.x < maxX)
        {
            if (spaceships[0] == gameObject && spaceships[0] != null)
            {
                Destroy(spaceships[1]);
            }
            else if (spaceships[0] != null)
            {
                Destroy(spaceships[0]);
            }
            twoShipsExist = false;
        }
    }

    /**
    void BondShips()
    {
        spaceships[1].transform.position = new Vector2(spaceships[0].transform.position.x + maxX * 2 * xSign, spaceships[0].transform.position.y);
        print("adidi");
    }
    **/
}
