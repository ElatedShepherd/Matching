using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

	public bool inputPress;

	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1"))
			inputPress = true;
		else
			inputPress = false;
	}
}
