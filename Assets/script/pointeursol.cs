using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointeursol : MonoBehaviour
{
    public Vector2 hotSpot = Vector2.zero;
    public Vector2 hotSpot1 = Vector2.zero;
    public Texture2D defaulttexture;
    public Texture2D pied;
    public bool isactive = false;
    public bool mouseover;
    public poniteur1 pointeur;
    public GameObject seringue;

    void OnMouseEnter()
    {
        
        
    }

    private void OnMouseOver()
    {
        mouseover = true;
        if (Time.timeScale == 0 || pointeur.inbutton)
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
        if (seringue.activeSelf == false)
        {
            gameObject.GetComponent<PolygonCollider2D>().points[16].Set(-0.0503967218f,-0.90249455f);
            gameObject.GetComponent<PolygonCollider2D>().points[17].Set(0.0586708263f,-0.828827262f);
        }
    }
}
