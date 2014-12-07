using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public bool touchingGround;
	public float sphereRadius = 0.5f;

	public Vector3 bounceVelocity = new Vector3(4, 3, 6 );
	public float time;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// This is a comment...

		/* This is a multiline comment
		 * Blah blah blah blah blah */

		touchingGround = IsTouching ();
		Debug.Log (IsTouching ());

		if ( touchingGround == true ) {
			Bounce( bounceVelocity );
		}
		rigidbody.AddTorque ( new Vector3( 0, 1, 10 ) );
		time += Time.deltaTime;
		if (time > 8) {
			enabled = false;
				}

	}
	
	void Function1 () {
	Debug.Log( "This is a function" );
		float tempVar = 1.1f;
		tempVar = 5.4f;
		}

	void Bounce ( Vector3 bounceVelocity ) {
		rigidbody.velocity = bounceVelocity;
		}

	bool IsTouching () {
		return Physics.Raycast (transform.position, Vector3.down, sphereRadius );
	}
}