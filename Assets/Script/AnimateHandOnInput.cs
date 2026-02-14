using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty triggerValue;
    public InputActionProperty gripValue;

    public Animator handAnimator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the Trigger and gripper values
        // from the XRI Default Input Actions
        float trigger = triggerValue.action.ReadValue<float>();        
        float grip = gripValue.action.ReadValue<float>();        

        // Update the Blend Tree anims of every hand
        handAnimator.SetFloat("Trigger", trigger);
        handAnimator.SetFloat("Grip", grip);
    }
}
