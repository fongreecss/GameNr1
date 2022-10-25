using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    int isRunningHash;

    // Start 
    void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
        Debug.Log(animator);
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool(isWalkingHash);
        bool forwardPressed = Input.GetKey(KeyCode.W);
        bool isRunning = animator.GetBool(isRunningHash);
        bool runPressed = Input.GetKey(KeyCode.LeftShift);

        // if player presses w key
        if (!isWalking && forwardPressed)
        {
            // then set isWalking to true
            animator.SetBool(isWalkingHash, true);
        } 
        // if W key is not pressed
        if(isWalking && !forwardPressed)
        {
            // then set isWalking to false
            animator.SetBool(isWalkingHash, false);
        }

        if (!isRunning && (forwardPressed && runPressed))
        {
            animator.SetBool(isRunningHash, true);
        }

        if (isRunning && (!forwardPressed || !runPressed))
        {
            animator.SetBool(isRunningHash, false);
        }

        
    }
}
