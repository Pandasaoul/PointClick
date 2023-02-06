using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class credit : MonoBehaviour
{
   
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                StartCoroutine(delayfin());
            }
        }
        
        IEnumerator delayfin()
                {
                    yield return new WaitForSeconds(23f);
                    SceneManager.LoadScene(0);
                    yield return new WaitForEndOfFrame();
                }
    
}
