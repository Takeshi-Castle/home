using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop_Time : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
       GameObject.Find("FPSController").SendMessage("Finnish");
            
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
