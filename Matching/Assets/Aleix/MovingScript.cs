using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScript : MonoBehaviour {

    public float speed;
    
    private void Awake()
    {
        GetComponent<Rigidbody>().velocity = Vector2.left * speed;

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
