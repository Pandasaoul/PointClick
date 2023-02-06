using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class murboutonexit : MonoBehaviour, IPointerExitHandler
{
    public GameObject mure;

    public void OnPointerExit(PointerEventData eventData)
    {
        mure.GetComponent<mur>().notdeplace = false;
    }
}
