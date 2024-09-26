using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float movementSpeed;
    [SerializeField] private float turnSmoothTime = 0.1f;
    [SerializeField] private Transform camera;

    private CharacterController characterController;
    private float turnSmoothVelocity;


    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }


    private void Update()
    {
        MovePlayer();
    }
    private void MovePlayer()
    {
        Vector2 moveInput =  GameInput.Instance.GetMovementVector();
        Vector3 direction = new Vector3(moveInput.x, 0f, moveInput.y).normalized;

        if(direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg+camera.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);


            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            characterController.Move(moveDir.normalized * movementSpeed * Time.deltaTime);

        }


        
    }






}
