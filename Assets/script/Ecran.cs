using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ecran : MonoBehaviour
{
    public player player;
    public GameObject dialogBox;
    public mur _mur;

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
        if (gameObject.CompareTag("Ecran") && player.playerInRangeEcran && Time.timeScale != 0)
        {
            StartCoroutine(WaitForMe());
        }
    }
    
    IEnumerator WaitForMe()
    {
        dialogBox.SetActive(true);
        yield return new WaitForSeconds(3.5f);
        dialogBox.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
