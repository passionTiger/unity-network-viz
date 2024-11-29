using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{ 
    public float rotateSpeed = 5.0f;
    public float zoomSpeed = 2.0f;
    void Update()
    { 
        // 회전
        if (Input.GetMouseButton(0))
        {
            float x = Input.GetAxis("Mouse X");
            float y = Input.GetAxis("Mouse Y");
            transform.Rotate(new Vector3(-y, x, 0) * rotateSpeed);
        }
        // 
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        transform.Translate(0, 0, scroll * zoomSpeed);
    }
}
