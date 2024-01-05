using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator characterAnimator;
    private static readonly int JumpTrigger = Animator.StringToHash("JumpTrigger");

    public void TriggerJumpAnimation()
    {
        characterAnimator.SetTrigger(JumpTrigger);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TriggerJumpAnimation(); // Call the existing method to trigger the jump animation
        }
    }
}