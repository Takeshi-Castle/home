using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public Text TimerText;
    private float startTime;
    private bool finnished = false;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {   
        if(finnished) return;
        else{

        float t = Time.time - startTime;

        string minutes = ((int) t / 60).ToString();
        string seconds = ( t % 60).ToString("f2");

        TimerText.text = minutes + ":" + seconds;
        }
    }
     
     public void Finnish(){
        finnished = true;
        TimerText.color = Color.green ;
     }
}
