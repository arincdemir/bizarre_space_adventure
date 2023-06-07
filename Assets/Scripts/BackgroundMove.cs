using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    public int layerNo;

    private float thisScrollSpeed;

    float height;
    float startDelay;
    float boostMultipler;
    

    float startTimeCounter = 0;

    // Start is called before the first frame update
    void Start()
    {

        
        startDelay = BackgroundVariables.instance.startDelay;
        height = BackgroundVariables.instance.height;

        switch (layerNo)
        {
            case 1:
                thisScrollSpeed = BackgroundVariables.instance.BG_1_speed;
                break;
            case 2:
                thisScrollSpeed = BackgroundVariables.instance.BG_2_speed;
                break;
            case 3:
                thisScrollSpeed = BackgroundVariables.instance.BG_3_speed;
                break;

        }
       
    }

    // Update is called once per frame
    void Update()
    {
        boostMultipler = BackgroundVariables.instance.multipler;
        if (startDelay < startTimeCounter)
        {
            Move();
            CheckIfTeleportNeeded();
        }
        else
        {
            startTimeCounter += Time.deltaTime;
        }
    }

    private void Move()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - thisScrollSpeed * Time.deltaTime * boostMultipler);
    }

    private void CheckIfTeleportNeeded()
    {
        if (transform.position.y < -height)
        {
            transform.position = new Vector2(transform.position.x , height);
        }
    }
}
