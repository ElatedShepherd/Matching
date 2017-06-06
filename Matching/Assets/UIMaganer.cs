using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIMaganer : MonoBehaviour {

    public float timeCount = 0;
    public Text timeText;

    // Use this for initialization
    void Start () {
 
    }

    // Update is called once per frame
    void Update () {
        if (!GameObject.Find("LogicSphere").GetComponent<Movement>().GameIsOver)
        {
            timeCount += Time.deltaTime;
        }
        ShowUI();
    }

    float roundedTime;
    void ShowUI()
    {
        roundedTime = Mathf.Round(timeCount);
        timeText.text = roundedTime.ToString();
    }
}
