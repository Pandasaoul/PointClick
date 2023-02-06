using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boutonexit : MonoBehaviour
{
    public GameObject menu;
    public bool pause;
    public void OnButtonPress()
    {
        menu.SetActive(true);
        Time.timeScale = 0;
    }
}
