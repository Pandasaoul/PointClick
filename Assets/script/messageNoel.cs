using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class messageNoel : MonoBehaviour
{
    

    public GameObject fondu;

    public bool isclicked;

    // Start is called before the first frame update
   

    



    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isclicked = true;

            if (isclicked == true && Input.GetMouseButtonDown(0))
            {
                
                    fondu.SetActive(true);
                    StartCoroutine(delayfin());
                
            }

        }
        IEnumerator delayfin()
        {
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene(5);
            yield return new WaitForEndOfFrame();
        }
    }
}
