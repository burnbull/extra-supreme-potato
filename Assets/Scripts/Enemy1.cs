using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : Enemy_inheritence{
	Vector2 speed = rb.velocity;
	private Rigidbody2D rb ;
	public bool direction;



	// Use this for initialization
	void Start () {
		alive = true;
		rb = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {








		if (alive && !direction) {




			rb.velocity = new Vector2 (speed.x, speed.y);

				





		} else if (alive && direction) {








			rb.velocity = new Vector2 (speed.x, speed.y);





		}






	}

	void OnCollisionEnter2D(Collision2D other)
	{

		if (other.gameObject.tag == "Player") {

			alive = false;

			transform.gameObject.tag = "Untagged";

			Destroy(gameObject,.5f);




		}



	}


	void OnTriggerEnter2D(Collider2D other) {

		if (other.CompareTag("Turn")) {

			if (direction==true) {
				
				vector2 (speed.x) = Random.Range(-1, -10);
				//Vector2 temp = rb.velocity;

				//rb.velocity = new Vector2 (5, temp.y);
				direction=false;

			}
			else if (direction==false) {
				

				vector2(speed.x) = Random.Range(1, 10);

				//Vector2 temp = rb.velocity;

				//rb.velocity = new Vector2 (-5, temp.y);
				direction=true;

			}

		}
	}
}
