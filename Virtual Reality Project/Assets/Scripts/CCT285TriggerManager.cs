using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CCT285TriggerManager : MonoBehaviour
{
    public UnityEvent triggerEnter;
    public UnityEvent triggerStay;
    public UnityEvent triggerExit;

    void OnTriggerEnter(Collider player)
    {
        Debug.Log("Object Entered the Trigger");
        triggerEnter.Invoke();
    }
    
    void OnTriggerStay(Collider player)
    {
        Debug.Log("Object Entered the Trigger");
        triggerStay.Invoke();
    }

    void OnTriggerExit(Collider player)
    {
        Debug.Log("Object Entered the Trigger");
        triggerExit.Invoke();
    }
}
