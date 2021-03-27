using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotation : MonoBehaviour
{
    public float speed = 0.1f;
    float angleX = 0.0f;
    float angleY = 0.0f;
    //public Transform playerBody;

    //float xRotation = 0f;
    private float mouseX = 0.0f;
    private float mouseY = 0.0f;
    void Start()
    {
            
    }

    private void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * speed;

        mouseY = Input.GetAxis("Mouse Y") * speed;
    }

    void LateUpdate()
    {
        angleX += mouseX;
        angleY += mouseY;
        angleY = Mathf.Clamp(angleY, -60, 60);
        transform.eulerAngles = new Vector3(-angleY, angleX, 0.0f);

        //xRotation -= mouseY;
        //xRotation = Mathf.Clamp(xRotation, -90f, 90f); // ����������� ������
        //transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); // ������� �� ���������
        //playerBody.Rotate(Vector3.up * mouseX);
    }

    //public Transform target;
    //public Vector3 offset;
    //public float sensitivity = 3; // ���������������� �����
    //public float limit = 80; // ����������� �������� �� Y
    //public float zoom = 0.25f; // ���������������� ��� ����������, ��������� �����
    //public float zoomMax = 10; // ����. ����������
    //public float zoomMin = 3; // ���. ����������
    //private float X, Y;

    //void Start()
    //{
    //	limit = Mathf.Abs(limit);
    //	if (limit > 90) limit = 90;
    //	offset = new Vector3(offset.x, offset.y, -Mathf.Abs(zoomMax) / 2);
    //	transform.position = target.position + offset;
    //}

    //void Update()
    //{
    //	if (Input.GetAxis("Mouse ScrollWheel") > 0) offset.z += zoom;
    //	else if (Input.GetAxis("Mouse ScrollWheel") < 0) offset.z -= zoom;
    //	offset.z = Mathf.Clamp(offset.z, -Mathf.Abs(zoomMax), -Mathf.Abs(zoomMin));

    //	X = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivity;
    //	Y += Input.GetAxis("Mouse Y") * sensitivity;
    //	Y = Mathf.Clamp(Y, -limit, limit);
    //	transform.localEulerAngles = new Vector3(-Y, X, 0);
    //	transform.position = transform.localRotation * offset + target.position;
    //}
}
