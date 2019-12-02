using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityStandardAssets.CrossPlatformInput;

public class CCT285Action : MonoBehaviour
{
    [Tooltip("Choose which button triggers Action")]
    public KeyCode actionButton = KeyCode.E;
    [Tooltip("Length of time (in seconds) needed to activate 'ActionHeld'")]
    public float holdTime = 0.1f;
    private float timePass = 0.0f;
    [Space(30)] // 10 pixels of spacing here.
    public UnityEvent actionButtonPressed;
    public UnityEvent actionButtonHeld;
    public UnityEvent actionButtonReleased;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(actionButton))
        {
            ActionPressed();
            timePass += Time.deltaTime;
            if (timePass > holdTime)
            {
                ActionHeld();
                timePass = 0.0f;
            }
        }
        
        if (Input.GetKeyUp(actionButton))
        {
            ActionReleased();
        }
    }

    void ActionPressed()
    {
        actionButtonPressed.Invoke();
    }

    void ActionHeld()
    {
        actionButtonHeld.Invoke();
    }

    void ActionReleased()
    {
        actionButtonReleased.Invoke();
    }
}
