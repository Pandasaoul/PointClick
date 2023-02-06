using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resume : MonoBehaviour
{
    public GameObject menu;
    public GameObject bouton;
    public void OnButtonPress()
    {
        menu.SetActive(false);
        Time.timeScale = 1;
        bouton.SetActive(true);
    }

    private void Update()
    {
        if (menu.activeSelf == true)
        {
            bouton.SetActive(false);
        }
    }
}
