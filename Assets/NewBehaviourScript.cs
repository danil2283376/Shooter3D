using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	// Start is called before the first frame update
	public int moveSpeed;

	private Rigidbody2D rb2d;
	void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		Move();
	}

	void Move() 
	{
		float moveX = Input.GetAxis("Horizontal");
		float moveY = Input.GetAxis("Vertical");
		print(moveX);
		print(" ");
		print(moveY);
	}
}
