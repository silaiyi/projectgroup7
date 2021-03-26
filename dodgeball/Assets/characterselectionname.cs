using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterselectionname : MonoBehaviour
{
    public Slider sd;
    public GameObject te;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (sd.value)
        {
            case 1: te.GetComponent<Text>().text = "Paul"; break;
            case 2: te.GetComponent<Text>().text = "Philip"; break;
            case 3: te.GetComponent<Text>().text = "Paula"; break;
            case 4: te.GetComponent<Text>().text = "Pamela"; break;
            case 5: te.GetComponent<Text>().text = "Eric"; break;
            case 6: te.GetComponent<Text>().text = "Erica"; break;
            case 7: te.GetComponent<Text>().text = "Steve"; break;
            case 8: te.GetComponent<Text>().text = "Sonia"; break;
            case 9: te.GetComponent<Text>().text = "Theodore"; break;
            case 10: te.GetComponent<Text>().text = "Titan"; break;
            case 11: te.GetComponent<Text>().text = "Cosima"; break;
            case 12: te.GetComponent<Text>().text = "Ciel"; break;
        }
    }
}
