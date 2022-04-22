using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveController : MonoBehaviour
{
    [SerializeField] private CharacterController _characterController;

    [SerializeField] private float _speed;
    [SerializeField] private float _gravity;
    [SerializeField] private float _groundDistance;

    [SerializeField] private LayerMask _groundMask;

    [SerializeField] private Transform _transform;

    public bool IsGrounded;

    private float _xPosition;
    private float _zPosition;

    private Vector3 _move;
    private Vector3 _velocity;




    private void Update()
    {
        IsGrounded = Physics.CheckSphere(_transform.position, _groundDistance, _groundMask);

        if (IsGrounded && _velocity.y < 0)
        {
            _velocity.y = -2f;
        }

        _xPosition = Input.GetAxis("Horizontal");
        _zPosition = Input.GetAxis("Vertical");

        _move = transform.right * _xPosition + transform.forward * _zPosition;

        _characterController.Move(_move * _speed * Time.deltaTime);

        _velocity.y -= _gravity * Time.deltaTime;

        _characterController.Move(_velocity * Time.deltaTime);
    }
}
