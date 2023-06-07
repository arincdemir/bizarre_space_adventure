using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpaceshipParticles : MonoBehaviour
{
    public GameObject bottomParticlePrefab;
    public GameObject leftParticlePrefab;
    public GameObject rightParticlePrefab;
    public GameObject blowingParticlePrefab;

    public float bottomYOffset;
    public float sideXOffset;
    public float sideYOffset;

    GameObject myBottomParticle;
    GameObject myLeftParticle;
    GameObject myRightParticle;

    ParticleSystem leftSystem;
    ParticleSystem rightSystem;
    
    bool leftThrustOn = false;
    bool rightThrustOn = false;

    // Start is called before the first frame update
    void Start()
    {
        myBottomParticle = Instantiate(bottomParticlePrefab, transform.position, Quaternion.identity);
        myBottomParticle.transform.position = new Vector2(transform.position.x, transform.position.y + bottomYOffset);
        myBottomParticle.name = "Bottom Particle";

        myLeftParticle = Instantiate(leftParticlePrefab, transform.position, Quaternion.identity);
        myLeftParticle.transform.position = new Vector2(transform.position.x - sideXOffset, transform.position.y + sideYOffset);
        myLeftParticle.name = "Left Particle";

        myRightParticle = Instantiate(rightParticlePrefab, transform.position, Quaternion.identity);
        myRightParticle.transform.position = new Vector2(transform.position.x + sideXOffset, transform.position.y + sideYOffset);
        myRightParticle.name = "Right Particle";

        leftSystem = myLeftParticle.GetComponent<ParticleSystem>();
        rightSystem = myRightParticle.GetComponent<ParticleSystem>();

    }

    // Update is called once per frame
    void Update()
    {
        myBottomParticle.transform.position = new Vector2(transform.position.x, transform.position.y + bottomYOffset);
        myLeftParticle.transform.position = new Vector2(transform.position.x - sideXOffset, transform.position.y + sideYOffset);
        myRightParticle.transform.position = new Vector2(transform.position.x + sideXOffset, transform.position.y + sideYOffset);

        if (leftThrustOn)
        {
            leftSystem.enableEmission = true;
        }
        else
        {
            leftSystem.enableEmission = false;
        }
        leftThrustOn = false;

        if (rightThrustOn)
        {
            rightSystem.enableEmission = true;
        }
        else
        {
            rightSystem.enableEmission = false;
        }
        rightThrustOn = false;
    }

    void OnDestroy()
    {
        Destroy(myBottomParticle);
        Destroy(myLeftParticle);
        Destroy(myRightParticle);
    }

    public void LeftThrust()
    {
        leftThrustOn = true;
    }

    public void RightThrust()
    {
        rightThrustOn = true;
    }

    public void BlownUp()
    {
        Instantiate(blowingParticlePrefab, transform.position, Quaternion.identity);
    }

}
