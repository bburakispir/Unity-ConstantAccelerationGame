using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour {

	void FixedUpdate()
	{
		transform.position += new Vector3(0.1F, 0, 0);		
	}




}

