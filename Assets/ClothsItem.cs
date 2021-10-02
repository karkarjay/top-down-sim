using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClothsItem : MonoBehaviour
{
    public Color[] color;
    public GameObject clopths;
    public GameObject CharCloths;
    public void Awake()
    {
        
    }

    public void Start()
    {
       
    }

    public void Cloths(int Okk)
    {
        for (int i = 0; i < color.Length; i++)
        {
            if (Okk==i)
            {
                PlayerPrefs.SetInt("Clothsh"+Okk,i);
                clopths.gameObject.GetComponent<Image>().color = color[i];
                CharCloths.GetComponent<SpriteRenderer>().color = color[i];  
            }
            
        }
    }

}
