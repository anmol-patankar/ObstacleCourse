using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int TimesHit = 0;
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag!="Hit")
        {
            TimesHit++;
        }
        Debug.Log(TimesHit);
    }  
}
