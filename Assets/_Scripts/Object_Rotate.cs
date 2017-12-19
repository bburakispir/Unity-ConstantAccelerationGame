using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Rotate : MonoBehaviour {
    float timeCounter = 0;
    float space=15;
    private Rigidbody2D rb;
    private Vector2 location;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        location = transform.position;
        timeCounter += Time.deltaTime;
        float x = Mathf.Cos(timeCounter);
        float y = Mathf.Sin(timeCounter);
        space += 15;
        rb.transform.position =new Vector2(rb.transform.position.x+x,rb.transform.position.y+y);
	}
}
