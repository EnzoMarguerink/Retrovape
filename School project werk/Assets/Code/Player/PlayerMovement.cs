using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	private Rigidbody m_rigidbody;

	private int ForwardSpeed = 10;
	private int JumpForce = 1;

	void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
	}

	void Update()
    {
		ForwardMove();
		Jump();
    }

	private void ForwardMove()
	{
		if (m_rigidbody.transform.position.y >= 0.2f)
		{
			GetComponent<Rigidbody>().AddForce(0, 0, 0 + ForwardSpeed * Time.deltaTime, ForceMode.VelocityChange);
		}
	}

	private void Jump()
	{
		if (Input.GetKey(KeyCode.Space))
		{
			if (m_rigidbody.transform.position.y <= 114)
			{
				GetComponent<Rigidbody>().AddForce(0, 0 + JumpForce, 0 * Time.deltaTime, ForceMode.VelocityChange);
			}
			else if (m_rigidbody.transform.position.y >= 114)
			{
				GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, 0);
			}
		}
		else
		{
			if (m_rigidbody.transform.position.y >= 2)
			{
				GetComponent<Rigidbody>().AddForce(0, 0 - 0.5f, 0 * Time.deltaTime, ForceMode.VelocityChange);
			}
		}
	}
}
