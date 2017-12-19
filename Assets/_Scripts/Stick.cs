using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour {
	public GameObject player;
	public GameObject Shapes;
	public HingeJoint2D hinge;
	public Rigidbody2D rb;
    public GameObject obje;
	public bool attached = false;
	private Hareket move;
    private float hiz;
    public Vector2 derece;
    public Vector2 derece2;
    public Vector2 derece3;
    public Vector2 derece4;

    public Vector2 angle;
    public bool attached00 = false;
    public bool attached01 = false;
    public bool attached10 = false;
    public bool attached11 = false;


    void Start()
	{
        move = GetComponent<Hareket> ();
        hiz = move.speed;
	}

	/*	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Player")
		{
			print ("COLLISION DETECTED!");
			player.AddComponent<HingeJoint2D>();
		}
	}   */

	void OnTriggerEnter2D(Collider2D collider)
	{
     
		if (collider.tag == "sekil" && !attached) {
			Debug.Log ("collision");
			attached = true;
			player = GameObject.FindGameObjectWithTag ("Player");
			player.AddComponent<HingeJoint2D> ();
			Shapes = collider.gameObject;
			hinge = player.GetComponent<HingeJoint2D> ();
        
            rb = Shapes.GetComponent<Rigidbody2D> ();
            obje = Shapes;
			hinge.connectedBody = rb;
			hinge.connectedAnchor = new Vector2 (0, -2.5f);
			move.speed = 0;

            angle = new Vector2(obje.transform.rotation.eulerAngles.z, 0);



            //Destroy (GetComponent <Hareket>());

            // if (obje.transform.rotation.eulerAngles.z < 270 && obje.transform.rotation.eulerAngles.z > 180 || obje.transform.rotation.eulerAngles.z > 130 && obje.transform.rotation.eulerAngles.z < 180)
            if (obje.transform.rotation.eulerAngles.z < 225 && obje.transform.rotation.eulerAngles.z >135)
            {
                attached00 = true;
                attached01 = false;
                attached10 = false;
                attached11 = false;
            }
            //else if (obje.transform.rotation.eulerAngles.z < 130 && obje.transform.rotation.eulerAngles.z > 45)
            else if(obje.transform.rotation.eulerAngles.z<135 && obje.transform.eulerAngles.z >45)
            {
                attached00 = false;
                attached01 = true; 
                attached10 = false;
                attached11 = false;
            }
           // else if (obje.transform.rotation.eulerAngles.z < 45 && obje.transform.rotation.eulerAngles.z > 0 || obje.transform.rotation.eulerAngles.z > -45 && obje.transform.rotation.eulerAngles.z < 0)
           else if (obje.transform.rotation.eulerAngles.z<45 && obje.transform.rotation.eulerAngles.z > 0 || obje.transform.rotation.eulerAngles.z>315 && obje.transform.rotation.eulerAngles.z<360)
            {
                attached00 = false;
                attached01 = false;
                attached10 = true;
                attached11 = false;

            }
            //else if (obje.transform.rotation.eulerAngles.z < -45 && obje.transform.rotation.eulerAngles.z > -130)
            else if (obje.transform.rotation.eulerAngles.z < 315 && obje.transform.rotation.eulerAngles.z >225)
            {
                attached00 = false;
                attached01 = false;
                attached10 = false;
                attached11 = true;
            }


        }
        else if (collider.tag == "collision") 
		{
			Destroy (player.gameObject);
		}
 
    }

	void Update()
    {
      
        if (Input.GetKeyDown ("space")) 
		{
            derece  = new Vector2(Mathf.Cos((obje.transform.rotation.eulerAngles.z) * Mathf.PI / 180), (Mathf.Sin((obje.transform.rotation.eulerAngles.z) * Mathf.PI / 180)));
            derece2 = new Vector2(Mathf.Cos((obje.transform.rotation.eulerAngles.z + 90) * Mathf.PI / 180), (Mathf.Sin((obje.transform.rotation.eulerAngles.z + 90) * Mathf.PI / 180)));
            derece3 = new Vector2(Mathf.Cos((obje.transform.rotation.eulerAngles.z + 180) * Mathf.PI / 180), (Mathf.Sin((obje.transform.rotation.eulerAngles.z + 180) * Mathf.PI / 180)));
            derece4 = new Vector2(Mathf.Cos((obje.transform.rotation.eulerAngles.z + 270) * Mathf.PI / 180), (Mathf.Sin((obje.transform.rotation.eulerAngles.z + 270) * Mathf.PI / 180)));

            angle = new Vector2(obje.transform.rotation.eulerAngles.z, 0);

            //float rotation = Input.GetAxis("Vertical") * 100;
            if (attached00==true)
            {
                move.jumpHeight = derece;
                attached00 = false;
            }
            else if (attached01 == true)
            {
                move.jumpHeight = derece2;
                attached01 = false;
            }
            else if (attached10 == true)
            {
                move.jumpHeight = derece3;
                attached10 = false;
            }
            else if (attached11 == true)
            {
                move.jumpHeight = derece4;
                attached11 = false;
            }

            Destroy(GetComponent<HingeJoint2D>());
			attached = false;
			move.speed = hiz;
           

        }
	}
}
