using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poniteurautrescene : MonoBehaviour
{
    public Vector2 hotSpot = Vector2.zero;
    public Vector2 hotSpot1 = Vector2.zero;
    public Texture2D defaulttexture;
    public Texture2D pied;
    public bool mouseover;

    void OnMouseEnter()
    {
        
        
    }

    private void OnMouseOver()
    {
        mouseover = true;
        if (Time.timeScale == 0)
        {
            Cursor.SetCursor(defaulttexture, hotSpot, CursorMode.Auto);
        }
        else
        {
            Cursor.SetCursor(pied, hotSpot1, CursorMode.Auto);
        }
    }

    private void OnMouseExit()
    {
        Cursor.SetCursor(defaulttexture, hotSpot, CursorMode.Auto);
    }

    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(defaulttexture, hotSpot, CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
