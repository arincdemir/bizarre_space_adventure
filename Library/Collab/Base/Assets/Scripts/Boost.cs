using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{

    bool isBoosted = false;
    float timePassed;
    public float boostTime;

    private GameObject asteroid;



    private float playerX;
    

    private float asteroidX;
    
    
    void Start()
    {
        timePassed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (isBoosted)
        {
            BackgroundVariables.instance.multipler = 10;
            timePassed += Time.deltaTime * 100;
        }

        if (timePassed > boostTime)
        {
            BackgroundVariables.instance.multipler = 1;
            isBoosted = false;
            timePassed = 0;
        }
        
    }
    
    void BoostEffect()
    {
        
        
       
                  

    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            BoostEffect();
            isBoosted = true;

            Debug.Log("Çarpışma yaşandı");
            BackgroundVariables.instance.multipler = 20;
            Destroy(gameObject);
        }
    }
}
