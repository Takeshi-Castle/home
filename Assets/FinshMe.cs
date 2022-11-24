using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class FinishMe : MonoBehaviour
{   
    // private bool ballattach = false;
    private void OnTriggerEnter(Collider other)
        {   
            // if(ballattach==false){
            //     if(other.CompareTag("BeachBall")){
            //     LvlManager.Next();
            //     }
            // }
            // else{
          
          if (other.CompareTag("FPSplayer"))
               LvlManager.Next();
        // }
    }
}
