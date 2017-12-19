using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public Vector2 jumpHeight;
    private GameObject oyuncu;
    private GameObject obje;
    private Stick attached;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        oyuncu = GameObject.FindGameObjectWithTag("Player");
        //obje = GameObject.FindGameObjectWithTag("sekil");
        attached = GetComponent<Stick>();


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);  //Hareket
        rb.AddForce(movement * speed);*/

 
            rb.transform.Translate(jumpHeight * speed * Time.deltaTime);

    }


}

