using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighter : MonoBehaviour
{
    [SerializeField] private GameObject Flame;
    //public GameObject MatchFlame;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Match")
        {
            //print("trigger success");
            Flame.SetActive(true);
            //MatchFlame.SetActive(false);
        }
        
    }
    
}