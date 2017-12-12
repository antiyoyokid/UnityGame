using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreattempt1 : MonoBehaviour {
    public static float scoreValue = 0;
    Text Score;
    

	// Use this for initialization
	void Start () {
        Score = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        scoreValue += Time.deltaTime;
        Score.text = "Score: " + scoreValue;
	}
}
