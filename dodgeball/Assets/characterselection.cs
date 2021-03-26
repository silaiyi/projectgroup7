using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterselection : MonoBehaviour
{
    public Slider sd;
    float index = 0;
    public Sprite a; //1
    public Sprite b; //2
    public Sprite c; //3
    public Sprite d; //4
    public Sprite e;//5
    public Sprite f;//6
    public Sprite g;//7
    public Sprite h;//8
    public Sprite i;//9
    public Sprite j;//10
    public Sprite k;//11
    public Sprite l;//12


    void Start()
    {
    }
    public void check()
    {
        index = sd.value;
    }



    public void charactershow()
    {
        switch (sd.value)
        {
            case 1: gameObject.GetComponent<Image>().sprite = a; break;
            case 2: gameObject.GetComponent<Image>().sprite = b; break;
            case 3: gameObject.GetComponent<Image>().sprite = c; break;
            case 4: gameObject.GetComponent<Image>().sprite = d; break;
            case 5: gameObject.GetComponent<Image>().sprite = e; break;
            case 6: gameObject.GetComponent<Image>().sprite = f; break;
            case 7: gameObject.GetComponent<Image>().sprite = g; break;
            case 8: gameObject.GetComponent<Image>().sprite = h; break;
            case 9: gameObject.GetComponent<Image>().sprite = i; break;
            case 10: gameObject.GetComponent<Image>().sprite = j; break;
            case 11: gameObject.GetComponent<Image>().sprite = k; break;
            case 12: gameObject.GetComponent<Image>().sprite = l; break;
        }
        
    }


}
