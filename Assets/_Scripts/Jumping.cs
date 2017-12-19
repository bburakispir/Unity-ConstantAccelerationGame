using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour {

    private Stick Player_Object;
    private Hareket move;
    private float hiz;
    public Vector2 derece;
    public Vector2 derece2;
    public Vector2 derece3;
    public Vector2 derece4;
    private void Start()
    {
        move = GetComponent<Hareket>();
        hiz = move.speed;
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown("space"))
        {
                derece = new Vector2(Mathf.Cos(Player_Object.obje.transform.rotation.eulerAngles.z * Mathf.PI / 180), (Mathf.Sin(Player_Object.obje.transform.rotation.eulerAngles.z * Mathf.PI / 180)));
        derece2 = new Vector2(Mathf.Cos((Player_Object.obje.transform.rotation.eulerAngles.z + 90) * Mathf.PI / 180), (Mathf.Sin((Player_Object.obje.transform.rotation.eulerAngles.z + 90) * Mathf.PI / 180)));
        derece3 = new Vector2(Mathf.Cos((Player_Object.obje.transform.rotation.eulerAngles.z + 180) * Mathf.PI / 180), (Mathf.Sin((Player_Object.obje.transform.rotation.eulerAngles.z + 180) * Mathf.PI / 180)));
         derece4 = new Vector2(Mathf.Cos((Player_Object.obje.transform.rotation.eulerAngles.z + 270) * Mathf.PI / 180), (Mathf.Sin((Player_Object.obje.transform.rotation.eulerAngles.z + 270) * Mathf.PI / 180)));

            Player_Object.angle = new Vector2(Player_Object.obje.transform.rotation.eulerAngles.z, 0);

            //float rotation = Input.GetAxis("Vertical") * 100;
            if (Player_Object.attached00 == true)
            {
               move.jumpHeight = derece;
                Player_Object.attached00 = false;
            }
            else if (Player_Object.attached01 == true)
            {
                move.jumpHeight = derece2;
                Player_Object.attached01 = false;
            }
            else if (Player_Object.attached10 == true)
            {
                move.jumpHeight = derece3;
                Player_Object.attached10 = false;
            }
            else if (Player_Object.attached11 == true)
            {
                move.jumpHeight = derece4;
                Player_Object.attached11 = false;
            }

            Destroy(Player_Object.GetComponent<HingeJoint2D>());
            Player_Object.attached = false;
            move.speed =hiz;


        }
    }
}
