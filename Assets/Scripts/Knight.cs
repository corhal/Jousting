using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.name != "LanceCollider" && Mathf.Approximately(other.attachedRigidbody.gravityScale, 0.0f)) {
			other.attachedRigidbody.AddForce (Vector2.right * 350.0f);
			other.attachedRigidbody.gravityScale = 1.0f;
		}

	}
}
