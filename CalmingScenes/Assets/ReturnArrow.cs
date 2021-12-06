using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnArrow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (transform.parent != null){
            Debug.Log("Arrow grabbed");
            SceneManager.LoadScene("Menu");
        } 
    }
}
