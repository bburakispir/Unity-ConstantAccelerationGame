using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObjects : MonoBehaviour {
	public GameObject kamera;
	void Start()
	{
		kamera = GameObject.FindGameObjectWithTag ("MainCamera");
	}

	void Update()
	{
		if (transform.position.x < kamera.transform.position.x-45 || transform.position.x > kamera.transform.position.x + 45) 
		{
            Destroy(gameObject);
        }
        else if (transform.position.y < kamera.transform.position.y - 45 || transform.position.y > kamera.transform.position.x + 45)
        {
            Destroy (gameObject);
        }
	}


}
