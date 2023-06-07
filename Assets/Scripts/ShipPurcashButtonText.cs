using System;
using UnityEngine;
using UnityEngine.UI;

public class ShipPurcashButtonText : MonoBehaviour
{
    

    Text text;
    public string name;
    public int cost;
    public string codeName;
    int num;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();

        if (PlayerPrefs.GetInt(codeName) == 0)
        {
            text.text = name + "\n" + cost + "dia";
        }
        else
        {
            text.text = name + "\n" + "OWNED";
        }

        num = (int)Char.GetNumericValue(codeName.ToCharArray()[2]);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt(codeName) == 0)
        {
            text.text = name + "\n" + cost + "dia";
        }
        else
        {
            text.text = name + "\n" + "OWNED";

        }

        print(num);
        print(PlayerPrefs.GetInt("SkinNum"));
        print(PlayerPrefs.GetInt("SkinNum") == num);

        if (PlayerPrefs.GetInt("SkinNum") == num)
        {
            text.text = name + "\n" + "EQUIPPED";
        }

    }


}
