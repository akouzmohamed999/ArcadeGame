﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour {

    private const float skinWidth = .02f;
    private const int TotalHorizontalRays = 8;
    private const int TotalVerticalRays = 4;

    private static readonly float SlopeLimitTangant = Mathf.Tan(75f * Mathf.Deg2Rad);


    public LayerMask PlatFormMask;
    public ControllerParameters2D DefaultParameters;

    public ControllerState2D State { get; private set; }
    public Vector2 Velocity { get; private set; }
    public bool CanJump { get { return false; } }

    public void Awake()
    {
        State = new ControllerState2D();   
    }
    public void AddForce(Vector2 force)
    {

    }
    public void SetForce(Vector2 force)
    {

    }
    public void SetHorizontalForce(float x)
    {

    }
    public void SetVerticalForce(float x)
    {

    }
    public void Jump()
    {

    }
    public void LateUpdate()
    {

    }
    private void Move(Vector2 deltaMovement)
    {

    }
    private void HandlePlatForms()
    {

    }
    private void CalculateRayOrigins()
    {

    }
    private void MoveHorizontally(ref Vector2 deltaMovement)
    {

    }
    private void MoveVertically(ref Vector2 deltaMovement)
    {

    }
    private void HandleVerticalSlope(ref Vector2 deltaMovemenet)
    {

    }
    private void HandleHorizontalSlope(ref Vector2 deltaMovemenet, float angle, bool isGoingRight)
    {

    }
    public void OnTriggerEnter2D(Collider2D other)
    {

    }
    public void OnTriggerExit2D(Collider2D other)
    {
        
    }
}
