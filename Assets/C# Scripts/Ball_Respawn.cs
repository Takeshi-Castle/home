using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

 
 public class Ball_Respawn : MonoBehaviour {
     public float threshold;
    //  public GameObject retryObject;
 
     void Update () {
        if(transform.position.y < threshold){
            this.transform.position= new Vector3( 50, 20, 15 );
            this.GetComponent<Rigidbody>().velocity= new Vector3( 0, 0, 0 );
        }
     }
            
}