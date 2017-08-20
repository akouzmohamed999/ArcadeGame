using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private bool _isFacingRight;
    private CharacterController2D _controller;
    private float _normalizeHorizontalSpeed;

    public float MaxSpeed = 8;
    public float SpeedAccelerationOnGround = 10f;
    public float SpeedAccelerationAir = 5f;

	void Start () {

        _controller = GetComponent<CharacterController2D>();
        _isFacingRight = transform.localScale.x > 0;
		
	}
	
	void Update () {

        HandleInput();

        var movementFactor = _controller.State.IsGrounded ? SpeedAccelerationOnGround : SpeedAccelerationAir;
        _controller.SetHorizontalForce(Mathf.Lerp(_controller.Velocity.x, _normalizeHorizontalSpeed * MaxSpeed, Time.deltaTime * movementFactor));
		
	}

    public void HandleInput()
    {
        if (Input.GetKey(KeyCode.D))
        {
            _normalizeHorizontalSpeed = 1;
            if (!_isFacingRight)
                Flip();
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            _normalizeHorizontalSpeed = -1;
            if (_isFacingRight)
                Flip();
        }
        else
        {
            _normalizeHorizontalSpeed = 0;
        }
        if(_controller.CanJump && Input.GetKeyDown(KeyCode.Space))
        {
            _controller.Jump();
        }
    }

    private void Flip()
    {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        _isFacingRight = transform.localScale.x > 0;
    }
}
