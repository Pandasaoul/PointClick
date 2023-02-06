using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/*public class Tirroirouvert : MonoBehaviour
{
    public Tirroir _tirroir1;
    public GameObject Gun;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _tirroir1.pause();
        }

        if (Time.timeScale != 1)
        {
            if (Input.GetMouseButtonUp(0))
            {
                _tirroir1.isclicked = true;
                if (_tirroir1.isclicked == true && Input.GetMouseButtonDown(0))
                {
                    _tirroir1.isclicked = false;

                    if (Time.timeScale == 0)
                    {
                        if (Input.GetMouseButtonUp(0))
                        {
                            Gun.SetActive(false);
                            _tirroir1.dialogBox.SetActive(false);
                            _tirroir1.dialogText.SetActive(false);
                            _tirroir1.persodialog.SetActive(false);
                            _tirroir1.darkscreen.SetActive(false);
                            _tirroir1.Gun.SetActive(false);
                            Destroy(_tirroir1.indicegrand);
                            Destroy(_tirroir1.hitboxRange);
                            for (int i = 0; i < _tirroir1.indicescript.Length; i++)
                            {
                                if (_tirroir1.indicescript[i].GetComponent<Laxatif>())
                                {
                                    _tirroir1.indicescript[i].gameObject.SetActive(true);
                                }

                                if (_tirroir1.indicescript[i].GetComponent<Soju>())
                                {
                                    _tirroir1.indicescript[i].gameObject.SetActive(true);
                                }

                                if (_tirroir1.indicescript[i].GetComponent<Seringue>())
                                {
                                    _tirroir1.indicescript[i].gameObject.SetActive(true);
                                }

                                if (_tirroir1.indicescript[i].GetComponent<Tissus>())
                                {
                                    _tirroir1.indicescript[i].gameObject.SetActive(true);
                                }

                                if (_tirroir1.indicescript[i].GetComponent<Cendrier>())
                                {
                                    _tirroir1.indicescript[i].gameObject.SetActive(true);
                                }

                                if (_tirroir1.indicescript[i].GetComponent<Ampoule>())
                                {
                                    _tirroir1.indicescript[i].gameObject.SetActive(true);
                                }

                                Time.timeScale = 1;
                                gameObject.SetActive(false);
                            }
                        }


                    }
                }

            }
        }
    }
}*/
