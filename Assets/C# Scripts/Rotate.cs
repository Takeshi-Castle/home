using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    float y;
    void Update()
    {
        y += Time.deltaTime * 100;
        transform.rotation = Quaternion.Euler(0,y,90);
    }
}
