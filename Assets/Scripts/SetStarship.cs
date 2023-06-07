using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStarship : MonoBehaviour
{
    public int number;
    public Vector2 position;
    private GameObject chosenShip;

    public GameObject SS0;
    public GameObject SS1;
    public GameObject SS2;
    public GameObject SS3;
    
    void Start()
    {
        number = PlayerPrefs.GetInt("SkinNum");

        switch (number)
        {
            case 0:
                chosenShip = SS0;
                break;
            case 1:
                chosenShip = SS1;
                break;
            case 2:
                chosenShip = SS2;
                break;
            case 3:
                chosenShip = SS3;
                break;

        }
        Spawner();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawner()
    {
        GameObject newShip = Instantiate(chosenShip, position, Quaternion.identity);
    }
}
