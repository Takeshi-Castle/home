using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

 
 public class Respawn : MonoBehaviour {
     public float threshold;
    //  public GameObject retryObject;
 
     void Update () {
        if(transform.position.y < threshold){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);}
        
     }
     private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Danger"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);}
            
}