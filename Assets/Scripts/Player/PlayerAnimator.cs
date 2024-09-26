using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [Header("Reference")]
    [SerializeField] private CharacterController characterController;


    private Animator animator;
    //Cache the Value for better performance
    private int f_moveDirectionX;
    private int f_moveDirectionY;

    private Vector3 velocityPlayer;


    private void Start()
    {
        animator = GetComponent<Animator>();
        f_moveDirectionX = Animator.StringToHash("f_moveDirectionX");
        f_moveDirectionY = Animator.StringToHash("f_moveDirectionY");


    }

    private void Update()
    {
        UpdateAnimatorVariables();
    }


    private void UpdateAnimatorVariables()
    {

        velocityPlayer = characterController.velocity;
        
        animator.SetFloat(f_moveDirectionX, velocityPlayer.x);
        animator.SetFloat(f_moveDirectionY, velocityPlayer.z);

    }

}
