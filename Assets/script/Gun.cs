using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/*public class Gun : MonoBehaviour
{
    private Camera cam;
    public bool gunclic;
    public bool isclicked;
    public Tirroir _Tirroir;

    void Update()
    {
        if (this == enabled)
        {
            if (gameObject.CompareTag("Gun") && Time.timeScale != 0)
            {
                gunclic = false;
                _Tirroir.pause();

                if (Input.GetMouseButtonUp(0))
                {
                    Time.timeScale = 1;
                    Destroy(_Tirroir);
                    Destroy(this);
                }
            }
            
        }

        /*void Start()
        {
            cam=Camera.main;
        }
    
    
        public void Update()
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 100f;
            mousePos = cam.ScreenToWorldPoint(mousePos);
    
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
    
                if (Physics.Raycast(ray, out hit, 100))
                {
                    if (hit.collider.CompareTag("Gun") && Time.timeScale != 0)
                    {
                        gunclic = false;
                    }
                    else
                    {
                        gunclic = true;
                    }
                }
            }*/


        /*if (Input.GetMouseButtonUp(0))
        {
            isclicked = true;
            if (isclicked && Input.GetMouseButtonDown(0))
            {
                isclicked = false;
                
                if (GameObject.tag"Gun" && Time.timeScale != 0)
                {
                    gunclic = false;
                }
                else
                {
                    gunclic = true;
                }
            }
        }
    }
}*/
