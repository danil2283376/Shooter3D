using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
	// пофиксить что бы персонаж не отрывался от земли при перемещении

    // Start is called before the first frame update
    public float speedMove = 0.3f;
    public int maximumSpeed = 10;

    private Rigidbody rb3d;
    private int move;
    void Start()
    {
        rb3d = GetComponent<Rigidbody>();
    }

	// Update is called once per frame
	void FixedUpdate()
	{
        Move();
    }

	void Move()
	{
        float speed = rb3d.velocity.magnitude;

        if (Input.GetKey(KeyCode.W) && speed < maximumSpeed)
        {
            // убираем перемещение по плоскости Y
            Vector3 movement = new Vector3(transform.forward.x, 0.0f, transform.forward.z);
            rb3d.AddForce(movement * speedMove, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.S) && speed < maximumSpeed)
        {
            // убираем перемещение по плоскости Y
            Vector3 movement = new Vector3(-transform.forward.x, 0.0f, -transform.forward.z);
            rb3d.AddForce(movement * speedMove, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.A) && speed < maximumSpeed)
            rb3d.AddForce(-transform.right * speedMove, ForceMode.Impulse);
        if (Input.GetKey(KeyCode.D) && speed < maximumSpeed)
            rb3d.AddForce(transform.right * speedMove, ForceMode.Impulse);

    }
}
