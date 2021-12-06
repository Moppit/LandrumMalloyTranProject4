using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bell : MonoBehaviour
{
    [SerializeField] private GameObject CandleFlame;
    //public GameObject MatchFlame;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GotoMenu()
    {
        SceneManager.LoadScene("Menu");
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Candle")
        {
            //print("trigger success");
            CandleFlame.SetActive(false);
            StartCoroutine(waiter());
            GotoMenu();
        }
        
    }
    IEnumerator waiter()
    {
        //Wait for 10 seconds
        yield return new WaitForSeconds(1);
    }
}
