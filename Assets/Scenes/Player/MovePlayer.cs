using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.3f;

    private Rigidbody rb3d;
	private CapsuleCollider collider;
    void Start()
    {
        rb3d = GetComponent<Rigidbody>();
		collider = GetComponent<CapsuleCollider>();
    }

	// Update is called once per frame
	void FixedUpdate()
	{
		Move();
	}

	void Move()
	{
		float moveX = Input.GetAxis("Horizontal");

		float moveY = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveX * speed, 0.0f, moveY * speed);
		if (rb3d.velocity.x < 5 && rb3d.velocity.z < 5) // ограничение скорости объекта
			rb3d.AddForce(movement, ForceMode.Impulse);
	}
}
