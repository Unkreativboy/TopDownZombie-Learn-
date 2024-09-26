using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{

    private PlayerInput playerInput;


    private void Awake()
    {
        playerInput = new PlayerInput();
        playerInput.Player.Enable();

    }


    public Vector2 GetMovementVector()
    {
        return playerInput.Player.Move.ReadValue<Vector2>();
    }



}
