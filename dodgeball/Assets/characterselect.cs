using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class characterselect : MonoBehaviour
{
    public int num = 3;
    public Slider sd;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (num == sd.value)
        {
            transform.position = new Vector3(0, 0.12f, -0.5f);
        }
        else
        {
            transform.position = new Vector3(100, 100, 100);
        }
    }
    
}
