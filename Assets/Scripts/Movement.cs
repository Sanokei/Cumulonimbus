using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float _speed = 10.0f;
    void Update()
    {
        float _translation_Z = Input.GetAxis("Vertical")   * _speed;
        float _translation_X = Input.GetAxis("Horizontal") * _speed;
        float _horizontal    = Input.GetAxis("Mouse X")    * _speed;

        _translation_Z *= Time.deltaTime;
        _translation_X *= Time.deltaTime;
        _horizontal    *= Time.deltaTime;
        
        transform.Translate(_translation_X, 0, _translation_Z);
        transform.Rotate(0, _horizontal, 0);
    }
}
