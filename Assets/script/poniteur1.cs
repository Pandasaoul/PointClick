using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class poniteur1 : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler
{
    public Vector2 hotSpot = Vector2.zero;
    public Vector2 hotSpot1 = Vector2.zero;
    public Texture2D defaulttexture;

    public bool inbutton;
    // Start is called before the first frame update
    void Update()
    {
        inbut();
    }

    void inbut()
    {
        if (inbutton )
        {
            Cursor.SetCursor(defaulttexture, hotSpot, CursorMode.Auto);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        inbutton = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        inbutton = false;
    }

}
