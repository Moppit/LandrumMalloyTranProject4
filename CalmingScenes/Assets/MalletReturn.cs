using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MalletReturn : MonoBehaviour
{
    public int time = 0;
    public Vector3 position;
    public Quaternion orientation;
    // Start is called before the first frame update
    void Start()
    {
        position = this.transform.position;
        orientation = this.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (time == 1){
            this.transform.position = position;
            this.transform.rotation = orientation;
            var rigidbody = GetComponent<Rigidbody>();
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
        }
        if(time >= 1){
            time -= 1;
            Debug.Log(time);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Plane")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Mallet Leaves");
            time = 50;
        }
    }
}
