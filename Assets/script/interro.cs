using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class interro : MonoBehaviour
{
    public GameObject interrolaxa;
    public GameObject interrotissus;
    public GameObject interrosoju;
    public GameObject interroseringue;
    public GameObject interroampoule;
    public GameObject interroclope;
    public GameObject interrogun;

    void Update()
    {
        if (interroampoule.activeSelf == false && interroclope.activeSelf == false && interrogun.activeSelf == false && interrolaxa.activeSelf == false && interroseringue.activeSelf == false && interrosoju.activeSelf == false && interrotissus.activeSelf == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(3);
            }
        }
    }
}
