using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {
	private Rigidbody2D rb ;
	public bool direction;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();



	}
	
	// Update is called once per frame
	void Update () {
		if (!direction) {

			rb.velocity = new Vector2 (3, 0);

		}


		else if (direction) {

			rb.velocity = new Vector2 (-3, 0);

		}

	}


	/*void OnTriggerEnter2D(Collider2D other) {

		if (other.CompareTag("Turn")) {

			if (direction==true) {


				//Vector2 temp = rb.velocity;

				//rb.velocity = new Vector2 (5, temp.y);
				direction=false;

			}
			else if (direction==false) {


				//Vector2 temp = rb.velocity;

				//rb.velocity = new Vector2 (-5, temp.y);
				direction=true;

			}

		}
	}*/



void OnTriggerEnter2D(Collider2D other) {

		if (other.CompareTag("Turn")) {

			if (direction==true) {
				

				//Vector2 temp = rb.velocity;

				//rb.velocity = new Vector2 (5, temp.y);
				direction=false;

			}
			else if (direction==false) {
				

				//Vector2 temp = rb.velocity;

				//rb.velocity = new Vector2 (-5, temp.y);
				direction=true;

			}

		}
	}



}
