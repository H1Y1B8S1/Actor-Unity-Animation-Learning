using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator characterAnimator;
    private static readonly int JumpTrigger = Animator.StringToHash("Jump");
    private static readonly int WalkTrigger = Animator.StringToHash("Walk");

    //private static readonly int FallTrigger = Animator.StringToHash("Fall");
    //private static readonly int RunTrigger = Animator.StringToHash("Run");
    //private static readonly int SprintTrigger = Animator.StringToHash("Sprint");
    //private static readonly int TalkTrigger = Animator.StringToHash("Talk");

    public void JumpAnimation()
    {
        characterAnimator.SetTrigger(JumpTrigger);
    }
    public void WalkAnimation()
    {
        characterAnimator.SetTrigger(WalkTrigger);
    }

    //public void FallAnimation()
    //{
    //    characterAnimator.SetTrigger(FallTrigger);
    //}
    //public void RunAnimation()
    //{
    //    characterAnimator.SetTrigger(RunTrigger);
    //}
    //public void SprintAnimation()
    //{
    //    characterAnimator.SetTrigger(SprintTrigger);
    //}
    //public void TalkAnimation()
    //{
    //    characterAnimator.SetTrigger(TalkTrigger);
    //}


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            JumpAnimation(); // Call the existing method to trigger the jump animation
        if (Input.GetKeyDown(KeyCode.W))
            WalkAnimation();

        //if (Input.GetKeyDown(KeyCode.E))
        //    TalkAnimation();
        //if (Input.GetKeyDown(KeyCode.LeftShift))
        //    RunAnimation();
        //if (Input.GetKeyDown(KeyCode.T))
        //    SprintAnimation();
        //if (Input.GetKeyDown(KeyCode.F))
        //    FallAnimation();
    }
}