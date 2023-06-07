using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveForceMultiplier;
    public float fuel;
    public float maxFuel;
    Rigidbody2D rb;

    Vector2 moveForce;
    Touch inputTouch;
    Vector2 inputPos;
    float maxX;
    SpaceshipParticles spaceshipParticles;
    public static bool ableToMove = true;

    void Start()
    {
        maxX = Camera.main.orthographicSize * Camera.main.aspect;
        rb = gameObject.GetComponent<Rigidbody2D>();
        spaceshipParticles = gameObject.GetComponent<SpaceshipParticles>();
    }

    void FixedUpdate()
    {
        if (ableToMove)
        {
            if (fuel > 0)
            {
                MovePC();
                MoveTouchDevice();
            }

            if (fuel > maxFuel) // yakıtı depodan fazla almasını engelledik brom --ii yapmıssın :)
            {
                fuel = maxFuel;
            }
            FuelBar.SetFuelBar(fuel / maxFuel);
        }
    }

    void MovePC()
    {
        float input = Input.GetAxisRaw("Horizontal");
        if(input < 0)
        {
            moveForce = new Vector2(-moveForceMultiplier, 0);
            rb.AddForce(moveForce * Time.deltaTime);
            fuel -= Time.deltaTime;
            spaceshipParticles.RightThrust();
        }
        else if(input > 0)
        {
            moveForce = new Vector2(moveForceMultiplier, 0);
            rb.AddForce(moveForce * Time.deltaTime);
            fuel -= Time.deltaTime;
            spaceshipParticles.LeftThrust();
        }
      
    }

    void MoveTouchDevice()
    {
        if(Input.touchCount > 0)
        {
            inputTouch = Input.GetTouch(0);
            inputPos = Camera.main.ScreenToWorldPoint(inputTouch.position);
            if(inputPos.x < 0)
            {
                moveForce = new Vector2(-moveForceMultiplier, 0);
                rb.AddForce(moveForce * Time.deltaTime);
                fuel -= Time.deltaTime;
                spaceshipParticles.LeftThrust();
            }
            else
            {
                moveForce = new Vector2(moveForceMultiplier, 0);
                rb.AddForce(moveForce * Time.deltaTime);
                fuel -= Time.deltaTime;
                spaceshipParticles.RightThrust();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Asteroid")
        {
            float x = collision.GetContact(0).point.x;
            if (x > maxX || x < -maxX)
            {
                //todo hızını eski hızına dönüştür.
                rb.velocity = new Vector2(rb.velocity.x, 0);
                Destroy(collision.gameObject);
            }
            else {
                SoundManagerScript.instance.Explosion();
                spaceshipParticles.BlownUp();
                GameManager.instance.LoseScreen();
            }
        }

        
    }
}
