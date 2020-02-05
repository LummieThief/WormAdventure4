using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Tells the worm whether it is grounded or not.
public class JumpTrigger : MonoBehaviour
{
	private bool grounded;

	private void OnTriggerStay(Collider other)
	{
		if (other.tag == "Solid")
		{
			grounded = true;
		}
	}
	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "Solid")
		{
			grounded = false;
		}
	}

	public bool getGrounded()
	{
		return grounded;
	}
}
