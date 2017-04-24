using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public InputManager IM;

	[Header ("Gravity")]
	public float grav;
	public float gravStart;
	public float gravIncrement;
	public float maxGrav;

	[Header ("Speed")]
	public float speed;
	public float speedStart;
	public float speedIncrement;
	public float maxSpeed;


	void Start (){
		speed = speedStart;
		grav = gravStart;
	}
	// Update is called once per frame
	void FixedUpdate () {
		ApplyGrav ();

		if (grav < maxGrav)
			AddGrav ();

		if (IM.inputPress) {
			ApplySpeed ();
			AddSpeed ();
		} else
			speed = speedStart;
	}

	void AddGrav () {
		grav += gravIncrement;
	}

	void ApplyGrav () {
		transform.position = transform.position - new Vector3 (0, grav, 0);
	}

	public void AddSpeed () {
		if (speed < maxSpeed)
			speed += speedIncrement;
	}

	public void ApplySpeed () {
		grav = gravStart;
		transform.position = transform.position + new Vector3 (0, speed, 0);
	}

}
