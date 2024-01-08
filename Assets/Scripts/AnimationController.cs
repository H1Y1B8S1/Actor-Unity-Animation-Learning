using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator characterAnimator;


    public void JumpAnimation()
    {
        //characterAnimator.SetTrigger(JumpTrigger);
    }
    public void WalkAnimation()
    {
        characterAnimator.SetBool("isWalking",true);
    }


    void Update()
    {
        bool walk = Input.GetKey(KeyCode.W);
        if (Input.GetKeyDown(KeyCode.Space))
            JumpAnimation(); // Call the existing method to trigger the jump animation
       if(walk)
            characterAnimator.SetBool("isWalking",true);
       if(!walk)
            characterAnimator.SetBool("isWalking", false);

    }
}