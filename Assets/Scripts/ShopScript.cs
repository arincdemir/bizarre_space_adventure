using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour
{
    public static ShopScript instance;
    public GameObject diamondsText;
    Text diaTextText;
    public GameObject SS1Text;
    public GameObject SS2Text;
    public GameObject SS3Text;

    public int ship1Cost;
    public int ship2Cost;
    public int ship3Cost;

    public Button SS0button;
    public Button SS1button;
    public Button SS2button;
    public Button SS3button;

    public ColorBlock equeppedColor;

    void Start()
    {
        instance = this;
        diaTextText = diamondsText.GetComponent<Text>();
        ship1Cost = SS1Text.GetComponent<ShipPurcashButtonText>().cost;
        ship2Cost = SS2Text.GetComponent<ShipPurcashButtonText>().cost;
        ship3Cost = SS3Text.GetComponent<ShipPurcashButtonText>().cost;
    }

    
    void Update()
    {
        diaTextText.text = PlayerPrefs.GetInt("Diamonds").ToString();
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }


    public void SetShip0()
    {
        PlayerPrefs.SetInt("SkinNum", 0);


    }

    public void SetShip1()
    {
        if(PlayerPrefs.GetInt("SS1") == 1)
        {
            PlayerPrefs.SetInt("SkinNum", 1);
        }
        else if (PlayerPrefs.GetInt("Diamonds") >= ship1Cost)
        {
            PlayerPrefs.SetInt("SS1", 1);
            PlayerPrefs.SetInt("Diamonds", PlayerPrefs.GetInt("Diamonds") - ship1Cost);
            PlayerPrefs.SetInt("SkinNum", 1);
            
            
        }
    }

    public void SetShip2()
    {
        if (PlayerPrefs.GetInt("SS2") == 1)
        {
            PlayerPrefs.SetInt("SkinNum", 2);
        }
        else if (PlayerPrefs.GetInt("Diamonds") >= ship2Cost)
        {
            PlayerPrefs.SetInt("SS2", 1);
            PlayerPrefs.SetInt("Diamonds", PlayerPrefs.GetInt("Diamonds") - ship2Cost);
            PlayerPrefs.SetInt("SkinNum", 2);

            
        }
    }
    public void SetShip3()
    {
        if (PlayerPrefs.GetInt("SS3") == 1)
        {
            PlayerPrefs.SetInt("SkinNum", 3);
        }
        else if (PlayerPrefs.GetInt("Diamonds") >= ship3Cost)
        {
            PlayerPrefs.SetInt("SS3", 1);
            PlayerPrefs.SetInt("Diamonds", PlayerPrefs.GetInt("Diamonds") - ship3Cost);
            PlayerPrefs.SetInt("SkinNum", 3);

            
        }
    }

    
   




}
