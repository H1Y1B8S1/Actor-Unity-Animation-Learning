using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator characterAnimator;
    private bool isWalking = false;

    void Update()
    {
        bool walk = Input.GetKey(KeyCode.W);
        bool run = Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift);

        // Update isWalking flag only when necessary to avoid redundant calls
        if (walk != isWalking)
        {
            isWalking = walk;
            characterAnimator.SetBool("isWalking", isWalking);
        }

        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            characterAnimator.SetTrigger("Jump");
        }
    }
}
