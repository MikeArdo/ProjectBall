using UnityEngine;
using System.Collections;

public class CoinScript : MonoBehaviour {
	public Transform GameObject;
	public Transform Coin;
	public int scoreValue = 2; 
	public int power = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    Coin.transform.Rotate (new Vector3 (0f, 0f, 1f), -4);
		}
	void OnTriggerEnter (Collider other)
	{
		if(other.tag == "sphere")
		{
			ScoreScript.score += scoreValue;
			PowerUpScore.powerScore += power;
			Destroy (this.gameObject);
		}
	}
}
