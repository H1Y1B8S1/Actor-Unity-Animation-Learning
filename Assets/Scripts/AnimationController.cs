using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator characterAnimator;
    private bool isWalking = false;

    public void JumpAnimation()
    {
        // Trigger jump animation
        characterAnimator.SetTrigger("JumpTrigger");
    }

    void Update()
    {
        bool walk = Input.GetKey(KeyCode.W);

        // Update isWalking flag only when necessary to avoid redundant calls
        if (walk != isWalking)
        {
            isWalking = walk;
            characterAnimator.SetBool("isWalking", isWalking);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpAnimation(); // Trigger jump animation
        }
    }
}
