using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class itemplush : MonoBehaviour
{
    
    public static itemplush instance;
    public TextMeshProUGUI Counter;
    public int buyprice;
    public int sellprice;
    public TextMeshProUGUI[] Quantity;
    private int buttonNumber;
    private int okk;


    

  
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void Start()
    {
        for (int i = 0; i < Quantity.Length; i++)
        {
            Quantity[i].text = PlayerPrefs.GetInt("item" + i).ToString();
        }
        Counter.text = "0";
    }

    public void Plush()
    {
        PlayerPrefs.SetInt("Plush",PlayerPrefs.GetInt("Plush",0)+1);
        Counter.text = PlayerPrefs.GetInt("Plush").ToString();

    }

    public void Minush()
    {
        if (PlayerPrefs.GetInt("Plush")>=1)
        {
            PlayerPrefs.SetInt("Plush", PlayerPrefs.GetInt("Plush") - 1);
            Counter.text = PlayerPrefs.GetInt("Plush").ToString();
        }
    }

    public void GetNumberItem(int okk)
    {
        buttonNumber = okk;
    }
    
    public void AddItem()
    {
        for (int i = 0; i < Quantity.Length; i++)
        {
            if (buttonNumber==i)
            {
                okk = PlayerPrefs.GetInt("item"+i) + PlayerPrefs.GetInt("Plush");
                 Quantity[i].text = okk.ToString();
                 PlayerPrefs.SetInt("item"+i,okk);
                PlayerPrefs.DeleteKey("Plush");
                Counter.text = "0";
            }
            
        }
        
    }
    
    
}
