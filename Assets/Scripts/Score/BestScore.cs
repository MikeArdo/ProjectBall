using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BestScore : MonoBehaviour {
	public static int score;
	public static int highScore;
	Text text;
	public static BestScore Best;

	void Awake (){
		text = GetComponent <Text> ();
	}
	// Use this for initialization
	void Start () {
		Best = this;
		highScore = PlayerPrefs.GetInt ("HighScore1", 0);
        text.text = "HighScore: " + highScore;
	}

	// Update is called once per frame
	void Update () {

	}
	public void CheckHighScore () {
		if (ScoreScript.score > highScore){
			PlayerPrefs.SetInt("HighScore1",ScoreScript.score);
		}
	}
}
