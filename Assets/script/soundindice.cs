using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundindice : MonoBehaviour
{
    public GameObject indice;
    public AudioSource sonindice;
    

    private void Start()
    { 
        sonindice = GetComponent<AudioSource>();
        
        
    }

    void Update()
    {
        
        if (indice.activeSelf)
        {
            sonindice.enabled = true;
        }
       
    }
}
