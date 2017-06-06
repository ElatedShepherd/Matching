using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //IMPTANTE


public class GameOver : MonoBehaviour {

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /*
     *     void OnEnable()
    {
        EnemyCountText.text = "ENEMIES KILLED: " +  MoveTest.EnemyCount.ToString();
        FinalExp.text = MoveTest.exp.ToString();

    }
    */

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // la escena actual del buildindex

    }

    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
