using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour {

	public float speed = 1f;

	void FixedUpdate () {
		transform.Translate(Vector3.left * Time.deltaTime * speed); 
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.CompareTag("Destroy")){
			Destroy (this.gameObject);
		}
	}

}
