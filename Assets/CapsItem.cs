using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CapsItem : MonoBehaviour
{
    public Color[] color;
    public GameObject cap;

    public void Awake()
    {
        
    }

    public void Start()
    {
        
    }
    public void Caps(int Okk)
    {
        for (int i = 0; i < color.Length; i++)
        {
            if (Okk==i)
            {
                PlayerPrefs.SetInt("Cap"+Okk,i);
                cap.gameObject.GetComponent<Image>().color = color[i];
               
                
            }
            
        }
    }
}
