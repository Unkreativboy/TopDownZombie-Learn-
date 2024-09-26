using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float movementSpeed;



    private CharacterController characterController;
     


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
        characterController.SimpleMove(new Vector3(moveInput.x,0,moveInput.y)*movementSpeed);
        
    }






}
