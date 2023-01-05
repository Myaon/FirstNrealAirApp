using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class CounterTrigger : MonoBehaviour
{
    public int cnt = 0;
    public Text location;

    void Start(){
        location.text = cnt.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        cnt++;
        location.text = cnt.ToString();
        //Debug.Log("すり抜けた！");
    }
}