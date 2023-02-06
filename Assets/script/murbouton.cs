using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class murbouton : MonoBehaviour, IPointerEnterHandler
{
    public GameObject mure;

    public void OnPointerEnter(PointerEventData eventData)
    {
        mure.GetComponent<mur>().notdeplace = true;
    }
    


}
