using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionset : MonoBehaviour
{
    public float X;
    void Start()
    {
        gameObject.transform.position = new Vector3(X, 0, 0);
    }

    private void Update()
    {
        gameObject.transform.position = new Vector3(X, 0, 0);
        
    }
}
