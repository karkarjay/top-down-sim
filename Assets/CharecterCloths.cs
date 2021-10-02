using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharecterCloths : MonoBehaviour
{

    public GameObject Shoes1;
    public GameObject Shoes2;
    public GameObject Cloths;
    public GameObject Goglesh;
    public GameObject Caps;
    public Color[] color;
    void Start()
    {
        for (int i = 0; i < color.Length; i++)
        {
            if (PlayerPrefs.GetInt("Cap"+i)==i)
            {
                Caps.GetComponent<SpriteRenderer>().color = color[i]; 
            }
            
        }
        for (int i = 0; i < color.Length; i++)
        {
            if (PlayerPrefs.GetInt("Goglesh"+i)==i)
            {
                Goglesh.GetComponent<SpriteRenderer>().color = color[i]; 
            }
            
        }
        for (int i = 0; i < color.Length; i++)
        {
            if (PlayerPrefs.GetInt("Shoesh"+i)==i)
            {
                Shoes1.GetComponent<SpriteRenderer>().color = color[i]; 
                Shoes2.GetComponent<SpriteRenderer>().color = color[i];
            }
            
        }
        for (int i = 0; i < color.Length; i++)
        {
            if (PlayerPrefs.GetInt("Clothsh"+i)==i)
            {
                Cloths.GetComponent<SpriteRenderer>().color = color[i]; 
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
