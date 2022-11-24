using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public GameObject retryObject;
    public void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        retryObject.SetActive(false);
    }
}
