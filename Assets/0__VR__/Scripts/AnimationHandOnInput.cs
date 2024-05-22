using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAnimation;
    public InputActionProperty gripAnimationAction;
    
    public Animator hadnAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchAnimation.action.ReadValue<float>();
        hadnAnimator.SetFloat("Trigger", triggerValue);

        float gripValue = gripAnimationAction.action.ReadValue<float>();
        hadnAnimator.SetFloat("Grip", gripValue);

    
        
    }
}
