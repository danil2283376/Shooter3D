using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotation : MonoBehaviour
{
    public float speedRotation = 0.5f;
    public GameObject lookAtObject;

    private Transform positionCamera;
    // Start is called before the first frame update
    void Start()
    {
        positionCamera = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RotationMouse() 
    {
        float x = Input.GetAxis("Mouse X");

        float y = Input.GetAxis("Mouse Y");

        Vector3 movement = new Vector3(x, 0.0f, y);
        positionCamera.position = movement;
    }
}
