﻿using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public bool ForwardInput { get; set; }
    public bool BackInput { get; set; }
    public bool LeftInput { get; set; }
    public bool RightInput { get; set; }
    public bool InteractionInput { get; set; }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) ForwardInput = true;
        else ForwardInput = false;
        if (Input.GetKey(KeyCode.S)) BackInput = true;
        else BackInput = false;
        if (Input.GetKey(KeyCode.A)) LeftInput = true;
        else LeftInput = false;
        if (Input.GetKey(KeyCode.D)) RightInput = true;
        else RightInput = false;
        if (Input.GetKeyDown(KeyCode.E)) InteractionInput = true;
        else InteractionInput = false;
    }
}
