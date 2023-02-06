using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mur : MonoBehaviour
{
    public  bool notdeplace;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseOver()
    {
        notdeplace = true;
    }

    private void OnMouseExit()
    {
        notdeplace = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
