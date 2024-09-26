using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{

    public static GameInput Instance { get; private set; }

    private PlayerInput playerInput;
    private void Awake()
    {
        Instance = this;

        playerInput = new PlayerInput();
        playerInput.Player.Enable();

    }


    public Vector2 GetMovementVector()
    {
        return playerInput.Player.Move.ReadValue<Vector2>();
    }

    public Vector2 GetMousePosition()
    {
        return playerInput.Player.Look.ReadValue<Vector2>();
    }



}
