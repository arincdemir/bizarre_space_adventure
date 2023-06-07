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
