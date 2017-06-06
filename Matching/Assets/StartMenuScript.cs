using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartMenuScript : MonoBehaviour {


    public string leveltoload = "Escena";


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Play();
        }
    }

    public void Play()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // la escena actual del buildindex
        SceneManager.LoadScene(leveltoload);

    }

    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }




}
