using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tuto : MonoBehaviour
{
    public GameObject tutoun;
    public GameObject tutodeux;
    

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
                tutoun.SetActive(false);
                tutodeux.SetActive(true);
        }

    }
}
