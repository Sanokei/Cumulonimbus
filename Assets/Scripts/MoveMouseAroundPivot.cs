using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMouseAroundPivot : MonoBehaviour
{
    [SerializeField]
    private Transform _camera;
    
    void Update(){
        //rotate the camera around an object
        _camera.RotateAround(transform.position, Vector3.up, Input.GetAxis("Mouse X") * 10);
    }
}
