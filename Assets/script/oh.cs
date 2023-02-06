using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oh : MonoBehaviour
{
    
    /*void Start()
    {
        StartCoroutine(LoadLevelAfterDelay());
    }
    
    IEnumerator LoadLevelAfterDelay()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(4);
    }*/
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(4);
        }
    }
}
