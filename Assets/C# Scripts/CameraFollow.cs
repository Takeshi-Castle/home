using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{   
    public Transform Head ;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        while(Input.GetKeyDown("c")){
            transform.position = new Vector3(transform.position.x, Head.transform.position.y - 1,transform.position.z);
        }
        
    }
}
