using UnityEngine;
using System.Collections;

public class VisualMovement : MonoBehaviour {

	public float lerpSpeed;
	public Transform parent;

	// Update is called once per frame
	void FixedUpdate () {
		transform.position = Vector3.Lerp (transform.position, parent.position, lerpSpeed);
	}
}
