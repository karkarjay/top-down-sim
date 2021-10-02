using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GogleshItem : MonoBehaviour
{
    public Color[] color;
    public GameObject goglesh;
    public GameObject CharGoglesh;

    public void Awake()
    {
        
    }

    public void Start()
    {
      
    }
    public void Goglesh(int Okk)
    {
        for (int i = 0; i < color.Length; i++)
        {
            if (Okk==i)
            {
                PlayerPrefs.SetInt("Goglesh"+Okk,i);
                goglesh.gameObject.GetComponent<Image>().color = color[i];
                CharGoglesh.GetComponent<SpriteRenderer>().color = color[i]; 
                
            }
            
        }
    }
}
