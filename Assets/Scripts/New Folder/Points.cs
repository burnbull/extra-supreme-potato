using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour {


	public int score;



	// Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void Update () {

		if (score >= 4) {


			Application.LoadLevel ("Scene1");



		}


	}
}
