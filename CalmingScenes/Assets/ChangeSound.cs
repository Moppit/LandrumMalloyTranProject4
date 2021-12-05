using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        toggle = true;
    }

    // Update is called once per frame
    void Update()
    {
        // change which sound is playing
        if(toggle) {
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

        // Check if you need to toggle
        if(Input.GetKeyDown("space")) {
            toggle = !toggle;
        }
    }
}
