using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotation : MonoBehaviour
{
    public float speed = 0.1f;
    
    private float angleX = 0.0f;
    private float angleY = 0.0f;
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
        // ��������� � ����
        angleX += mouseX;
        angleY += mouseY;
        // ����������� ����������� �� ��� Y
        angleY = Mathf.Clamp(angleY, -60, 60);
        // ����� ������� �������� ���������
        transform.eulerAngles = new Vector3(-angleY, angleX, 0.0f);
    }
}
