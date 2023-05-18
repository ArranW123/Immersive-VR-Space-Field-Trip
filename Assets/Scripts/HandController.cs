using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class HandController : MonoBehaviour
{
    public InputAction action = null;
    public UnityEvent OnPress = new UnityEvent();
    public UnityEvent OnRelease = new UnityEvent();
    

    void Awake() {
        action.started += Pressed;
        action.canceled += Released;    
    }

    void OnDestroy()
    {
        action.started -= Pressed;
        action.canceled -= Released;
    }

    void OnEnable(){
        action.Enable();
    }
    void OnDisable(){
        action.Disable();
    }
    void Pressed(InputAction.CallbackContext context)
    {
        OnPress.Invoke();
    }
    void Released(InputAction.CallbackContext context)
    {
        OnRelease.Invoke();
    }

}

