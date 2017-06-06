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

    [Header("Manager")]
    public GameObject GameOverScreen;
    public bool GameIsOver;

    void Start (){
		speed = speedStart;
		grav = gravStart;
        GameIsOver = false;
        Debug.Log("Scene Start");
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

        if (Input.GetKeyDown(KeyCode.R))
        {
            Death();
        }
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

    void Death()
    {
        GameOverScreen.SetActive(true);  //se activa el panel de gameOver
        GameIsOver = true;
    }

}
