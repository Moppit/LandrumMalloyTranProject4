using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour
{
    [SerializeField] private GameObject CandleFlame;
    public GameObject MatchFlame;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Match")
        {
            //print("trigger success");
            CandleFlame.SetActive(true);
            MatchFlame.SetActive(false);
        }
        
    }
    
}