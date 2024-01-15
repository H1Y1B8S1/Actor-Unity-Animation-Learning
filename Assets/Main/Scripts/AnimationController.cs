using UnityEngine;

public class AnimationController : MonoBehaviour
{
    //public Animator characterAnimator;
    public Transform ovrControllerRig; // Reference to your OVRControllerRig GameObject

    public float walkSpeed = 3f; // Adjust the speed as needed
    public float rotationSpeed = 90f; // Adjust the rotation speed as needed

    void Update()
    {
        float triggerLeft = OVRInput.Get(OVRInput.RawAxis1D.LIndexTrigger); // between 0 and 1.
        float triggerRight = OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger);


        // Additional buttons on the Oculus Touch controllers
        bool buttonA = OVRInput.Get(OVRInput.Button.One); // Button A
        bool buttonB = OVRInput.Get(OVRInput.Button.Two); // Button B
        bool buttonX = OVRInput.Get(OVRInput.Button.Three); // Button X
        bool buttonY = OVRInput.Get(OVRInput.Button.Four); // Button Y


        // Move forward if the left trigger is pressed
        if (triggerLeft > 0.9)
        {
            Vector3 moveDirection = ovrControllerRig.forward;
            ovrControllerRig.Translate(moveDirection * walkSpeed * Time.deltaTime, Space.World);
        }

        // Rotate around if the right trigger is pressed
        if (triggerRight > 0.9)
        {
            float rotationInput = OVRInput.Get(OVRInput.RawAxis1D.RHandTrigger); // You can use another trigger for rotation if needed
            float rotationAmount = rotationInput * rotationSpeed * Time.deltaTime;
            ovrControllerRig.Rotate(Vector3.up, rotationAmount);
        }

        // Additional functionality based on button presses
        if (buttonA)
        {
            // Do something when Button A is pressed
        }

        if (buttonB)
        {
            // Do something when Button B is pressed
        }

        if (buttonX)
        {
            // Do something when Button X is pressed
        }

        if (buttonY)
        {
            // Do something when Button Y is pressed
        }


    }
}






/* 
    private bool isWalking = false;
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
    }*/