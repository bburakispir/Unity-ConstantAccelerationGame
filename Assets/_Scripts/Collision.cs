﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "player") {

			Destroy (collider.gameObject);
		}

	}

}
