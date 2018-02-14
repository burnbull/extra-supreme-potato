using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controlls : MonoBehaviour {
	
	private Rigidbody2D rb;

	public float runSpeed;
	public float jumpForce;

	Skill skill1;

	bool doublejump;
	bool jumping;
	bool grounded;
	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody2D> ();

		jumping = false;
		grounded = false;

		skill1 = new Skill ();

		skill1.level = 10;
		skill1.name = "fire";
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float horizontal = Input.GetAxis ("Horizontal");
		Vector2 movement = new Vector2(horizontal,0.0f);

		rb.AddForce (movement * runSpeed * Time.deltaTime);



		RaycastHit2D hit = Physics2D.Raycast (new Vector3 (transform.position.x, transform.position.y - (GetComponent<BoxCollider2D> ().bounds.size.y / 2) - 0.1f, 0.0f), Vector2.down);


		if (hit) {
			if (hit.distance <= 0.1f) {
				grounded = true;
				doublejump = true;
			} else {
				grounded = false;
			}

		} else {
			grounded = false;
		}


		float jumpAxis = Input.GetAxis("Jump");

		if (jumpAxis > 0 && !jumping && grounded) {


			jumpStart ();
		} else if (jumpAxis > 0 && !jumping && doublejump && !grounded) {

			Vector3 temp = rb.velocity;

			rb.velocity = new Vector3 (temp.x, 0, 0);
			jumpStart ();


			doublejump = false;

		}




		else if(jumpAxis==0){
			jumping = false;

		}


		//if (Input.GetAxis ("Fire1") > 0) {
		if (Input.GetKeyDown("z")) {
			string output = skill1.use ();
			print (output);

		}



	}

	void OnTriggerEnter2D(Collider2D other) {

		if (other.CompareTag ("KillZone")) {
			Application.LoadLevel ("Scene1");

		} else if (other.CompareTag ("Coin")) {


			print ("ey");
		}
	}









	void jumpStart(){
		Vector2 jumpMovement = new Vector2(0,jumpForce);
		jumping = true;
		rb.AddForce (jumpMovement * jumpForce * Time.deltaTime);
	}



}