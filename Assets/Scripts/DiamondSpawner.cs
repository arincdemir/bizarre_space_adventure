using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondSpawner : MonoBehaviour
{
    public GameObject fuelPrefab;
    public float expectedDiamondDelay;
    public float velocityY = -2;

    float maxX;

    // Start is called before the first frame update
    void Start()
    {
        maxX = Camera.main.orthographicSize * Camera.main.aspect;
    }

    // Update is called once per frame
    void Update()
    {
        if(Random.value <= Time.deltaTime / expectedDiamondDelay)
        {
            GameObject newDiamond;
            newDiamond = Instantiate(fuelPrefab, new Vector2(Random.Range(-maxX,maxX), transform.position.y), Quaternion.identity);
            newDiamond.transform.parent = transform;
            newDiamond.GetComponent<Rigidbody2D>().velocity = new Vector2(0, velocityY);
        }


    }
}
