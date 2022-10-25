using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;

    // Start 
    void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        Debug.Log(animator);
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool(isWalkingHash);
        bool forwardPressed = Input.GetKey(KeyCode.W);
        
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
    }
}
