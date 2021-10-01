using System.Collections;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem.Wrappers;
using UnityEngine;

public class OpenDailogPanel : MonoBehaviour
{
    
    
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player"))
        {
            gameObject.GetComponent<DialogueSystemTrigger>().enabled = true;
        }
    }
}
