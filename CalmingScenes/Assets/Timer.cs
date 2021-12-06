using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] public Text timeText_1;
    [SerializeField] public Text timeText_2;
    [SerializeField] public GameObject Flame;
    public float timeRemaining = 600;
    public float timer = 1000;
    public bool timerIsRunning = false;

    private void Start()
    {
        // Starts the timer automatically
        //timerIsRunning = true;
        //timeText_1.enabled = true;
        //timeText_1.gameObject.SetActive(true);
    }

    void Update()
    {
        // if(flame.activeSelf == true) //if the candle has been lit by user --> UI text prompts guided breathing exercise starts
        // {
             //timeText_1.gameObject.SetActive(true);
        // }
        if(Flame.activeSelf == true)
        {
            timerIsRunning = true;
            timeText_1.gameObject.SetActive(true);
        }

        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                timer -= Time.deltaTime; //doesn't seem to work with Time.deltaTime??
                //timer -= 1;   //this works, but is too fast??
                //print("running!");
                if(timer == 0)
                {
                    print("Inside timer if statement!");
                    //timeText_1.enabled = false;
                    //timeText_2.enabled = true;
                    timeText_1.gameObject.SetActive(false);
                    timeText_2.gameObject.SetActive(true);
                    timer = 1000;
                }
                //DisplayTime(timeRemaining);
            }
            else
            {
                //Debug.Log("Game Over.");
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }

    // void DisplayTime(float timeToDisplay)
    // {
    //     if(timeToDisplay < 0)
    //     {
    //         timeToDisplay = 0;
    //     }
    //     else if(timeToDisplay > 0)
    //     {
    //         timeToDisplay += 1;
    //     }
        
    //     // float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
    //     // float seconds = Mathf.FloorToInt(timeToDisplay % 60);
    //     //timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            
    // }
}