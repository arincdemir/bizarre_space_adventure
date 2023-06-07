using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Rand_Teleport : MonoBehaviour
{
    public Transform T;
    public PlayerMovement PM;
    
    public float max;
    public float min;
    public float fuelNeed;
    

    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RandomTeleportX();
        }
    }

    void RandomTeleportX()
    {
        float randNum = Random.Range(min , max);
        T.position = new Vector3(randNum, T.position.y , T.position.z);
        PM.fuel -= fuelNeed;
    }


}
