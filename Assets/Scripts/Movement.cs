using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    [SerializeField] float _speed = 10.0f;
    [SerializeField] Transform _cameraTransform ;
    CharacterController _controller;
    private Vector3 _moveDirection = Vector3.zero;
    
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        _moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _moveDirection = _cameraTransform.TransformDirection(_moveDirection);
        _moveDirection *= _speed;
        _controller.Move(_moveDirection * Time.deltaTime);
        _controller.transform.position.Set(_controller.transform.position.x,100,_controller.transform.position.z);
        
    }
}
