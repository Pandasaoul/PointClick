using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tissus : MonoBehaviour
{
    public GameObject dialogBox;
    public GameObject dialogText;
    public GameObject persodialog;
    public GameObject interro;
    public GameObject darkscreen;
    public GameObject indicegrand;
    public GameObject icone;
    public GameObject menu;
    public player player;
    public GameObject hitboxRange;
    /*public GameObject hitboxRangesoju;
    public GameObject hitboxRangeseringue;
    public GameObject hitboxRangeclope;
    public GameObject hitboxRangetissus;
    public GameObject Ampoule;*/
    public GameObject[] indicescript;
    public bool isclicked;
    public bool dejafait;
    public mur _mur;
    public GameObject bouton;

    void OnMouseOver()
    {
        _mur.notdeplace = true;
    }

    private void OnMouseExit()
    {
        _mur.notdeplace = false;
    }




    void OnMouseUp()
    {
        if (gameObject.CompareTag("Tissus") && player.playerInRangeTissus && Time.timeScale != 0)
        {
            if (dejafait == false)
            {
                bouton.SetActive(false);
                dialogBox.SetActive(true);
                dialogText.SetActive(true);
                persodialog.SetActive(true);
                darkscreen.SetActive(true);
                indicegrand.SetActive(true);
                interro.SetActive(false);
                icone.SetActive(true);

                for (int i = 0; i < indicescript.Length; i++)
                {
                    if (indicescript[i].GetComponent<Ampoule>())
                    {
                        indicescript[i].GetComponent<Ampoule>().enabled = false;
                    }

                    if (indicescript[i].GetComponent<Soju>())
                    {
                        indicescript[i].GetComponent<Soju>().enabled = false;
                    }

                    if (indicescript[i].GetComponent<Seringue>())
                    {
                        indicescript[i].GetComponent<Seringue>().enabled = false;
                    }

                    if (indicescript[i].GetComponent<Laxatif>())
                    {
                        indicescript[i].GetComponent<Laxatif>().enabled = false;
                    }

                    if (indicescript[i].GetComponent<Cendrier>())
                    {
                        indicescript[i].GetComponent<Cendrier>().enabled = false;
                    }

                    if (indicescript[i].GetComponent<Tirroir>())
                    {
                        indicescript[i].GetComponent<Tirroir>().enabled = false;
                    }

                }

                Time.timeScale = 0;
                dejafait = true;
            }
        }

    }
    

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isclicked = true;
            if (isclicked == true && Input.GetMouseButtonDown(0))
            {
                isclicked = false;
                if (Time.timeScale == 0 && menu.activeSelf == false)
                {
                    bouton.SetActive(true);
                    dialogBox.SetActive(false);
                    dialogText.SetActive(false);
                    persodialog.SetActive(false);
                    interro.SetActive(false);
                    darkscreen.SetActive(false);
                    
                    indicegrand.gameObject.SetActive(false);
                    hitboxRange.SetActive(false);
                    for (int i = 0; i < indicescript.Length; i++)
                    {
                        if (indicescript[i].GetComponent<Ampoule>())
                        {
                            indicescript[i].GetComponent<Ampoule>().enabled=true;
                        }
                        if (indicescript[i].GetComponent<Soju>())
                        {
                            indicescript[i].GetComponent<Soju>().enabled=true;
                        }
                        if (indicescript[i].GetComponent<Seringue>())
                        {
                            indicescript[i].GetComponent<Seringue>().enabled=true;
                        }
                        if (indicescript[i].GetComponent<Laxatif>())
                        {
                            indicescript[i].GetComponent<Laxatif>().enabled=true;
                        }
                        if (indicescript[i].GetComponent<Cendrier>())
                        {
                            indicescript[i].GetComponent<Cendrier>().enabled=true;
                        }
                        if (indicescript[i].GetComponent<Tirroir>())
                        {
                            indicescript[i].GetComponent<Tirroir>().enabled=true;
                        }

                    }
                    _mur.notdeplace = false;
                    Time.timeScale = 1;
                    gameObject.SetActive(false);
                    
                }
            }
                
        }
        
        
    }
}
