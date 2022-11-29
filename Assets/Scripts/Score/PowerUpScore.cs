using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PowerUpScore : MonoBehaviour {
	public static int score;
	public static int powerScore;
	Text text;
	public static PowerUpScore Power;

	void Awake (){
		text = GetComponent <Text> ();
	}
	// Use this for initialization
	void Start () {
		Power = this;
		powerScore = PlayerPrefs.GetInt ("PowerScore1", 0);

	}
	
	// Update is called once per frame
	void Update () {
		text.text = "" + powerScore;
	}
	public void CheckHighScore () {

			PlayerPrefs.SetInt("PowerScore1", powerScore);
			//			Debug.Log ("Saving score "+ powerScore);

	}
}
