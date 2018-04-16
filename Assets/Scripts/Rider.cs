using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rider : MonoBehaviour {

	public Knight Knight;

	Rigidbody2D Rigidbody;
	public float Speed;

	void Awake () {
		Rigidbody = GetComponent<Rigidbody2D> ();
	}
		
	void Start () {
		Rigidbody.velocity = Vector2.right * Speed;
		Knight.gameObject.GetComponent <Rigidbody2D>().velocity = Vector2.right * Speed;
	}	
}
