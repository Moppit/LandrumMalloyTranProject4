using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSound : MonoBehaviour
{
    // Audio sources
    public AudioSource crickets;
    public AudioSource guide;
    private bool toggle;

    // Start is called before the first frame update
    void Start()
    {
        crickets.Stop();
        guide.Stop();
        toggle = false;
    }

    // Update is called once per frame
    void Update()
    {
        // change which sound is playing
        if(!toggle) {
            if(!crickets.isPlaying) {
                crickets.Play();
                guide.Stop();
            }
        }
        else {
            if(!guide.isPlaying) {
                guide.Play();
                crickets.Stop();
            }
        }

        // Toggle on Oculus button press
        if(OVRInput.GetDown(OVRInput.Button.One)) {
            toggle = true;
        }
        if(OVRInput.GetDown(OVRInput.Button.Two)) {
            toggle = false;
        }

        // Additional function that should probably be in a different file but is here bc idk where else to put it
        if(OVRInput.GetDown(OVRInput.Button.Three)) {
            SceneManager.LoadScene("Menu");
        }
    }
}
