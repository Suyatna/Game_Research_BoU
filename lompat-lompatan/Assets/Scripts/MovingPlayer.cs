using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlayer : MonoBehaviour {

    public float speed = 5.0f;
    public float jumpForce;

    private Rigidbody2D myRigidbody;

	// Use this for initialization
	void Start () {
        myRigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            //myRigidbody.velocity = new Vector2(speed, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            //myRigidbody.velocity = new Vector2(-speed, 0);
        }
		
        if (Input.GetKey(KeyCode.W))
        {
            myRigidbody.velocity = new Vector2(0, jumpForce);
        }
	}
}
