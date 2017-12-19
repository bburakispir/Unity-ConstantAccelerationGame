using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContanct : MonoBehaviour {

	public GameObject explosion;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Boundary") 
		{
			return;
		}

		
		if (other.tag == "Player") 
		{

            Instantiate(explosion, transform.position, transform.rotation);

            Destroy (other.gameObject);
		    Destroy (gameObject);


		}
		
	}
}
