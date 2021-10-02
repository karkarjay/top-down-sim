using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoesItem : MonoBehaviour
{
    public Color[] color;
    public GameObject shoesh;
    public GameObject CharShoesh1;
    public GameObject CharShoesh2;
    public void Awake()
    {
        
    }

    public void Start()
    {
        
    }
    public void Shoesh(int Okk)
    {
        for (int i = 0; i < color.Length; i++)
        {
            if (Okk==i)
            {
                PlayerPrefs.SetInt("Shoesh"+Okk,i);
                shoesh.gameObject.GetComponent<Image>().color = color[i];
                CharShoesh1.GetComponent<SpriteRenderer>().color = color[i]; 
                CharShoesh2.GetComponent<SpriteRenderer>().color = color[i];
                
            }
            
        }
    }
}
