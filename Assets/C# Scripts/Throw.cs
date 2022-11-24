using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    
    public Transform dest;
    bool isgrounded = true;

    public void Update(){
        if(this.transform.position.y > 19 && this.transform.position.y < 20){
            isgrounded = true;
        }
        else {
            isgrounded = false;
        }
    }
    void OnMouseDown(){
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = dest.position;
        this.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
        this.GetComponent<SphereCollider>().enabled=false;
        this.transform.parent = GameObject.Find("Destination").transform;
        isgrounded = false;

    }

    void OnMouseUp(){
        GetComponent<Rigidbody>().useGravity = true;
        this.GetComponent<SphereCollider>().enabled=true;
        // this.transform.position = dest.position;
        this.transform.parent = null;
        this.GetComponent<Rigidbody>().AddForce(dest.transform.forward * 300.0f);
        // this.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
        if(isgrounded){
            this.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
        }
    }
}
