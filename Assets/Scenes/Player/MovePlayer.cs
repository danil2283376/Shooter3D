using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
	//Õ¿œ»—¿“‹ ÕŒ–Ã¿À‹ÕŒ≈ œ≈–≈Ã≈Ÿ≈Õ»≈ Œ¡⁄≈ “¿ ¬ “” —“Œ–ŒÕ”  ”ƒ¿ —ÃŒ“–»“ »√–Œ 

    // Start is called before the first frame update
    public float speedMove = 0.3f;
	public float speedRotation = 0.3f;

    private Rigidbody rb3d;
    void Start()
    {
        rb3d = GetComponent<Rigidbody>();
    }

	// Update is called once per frame
	void FixedUpdate()
	{
		
		//Move();
	}

	void Move()
	{
		//float moveX = Input.GetAxis("Horizontal");

		//float moveY = Input.GetAxis("Vertical");

		//Vector3 movement = new Vector3(moveX * speed, 0.0f, moveY * speed);
		//if (rb3d.velocity.x < 5 && rb3d.velocity.z < 5) // Ó„‡ÌË˜ÂÌËÂ ÒÍÓÓÒÚË Ó·˙ÂÍÚ‡
		//	rb3d.AddForce(movement, ForceMode.Impulse);
	}
}
