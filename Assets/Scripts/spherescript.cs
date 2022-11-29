using UnityEngine;
using System.Collections;

public class spherescript : MonoBehaviour {
	public Transform Sphere;
	public Transform GameObject;
	public int scoreValue = 1; 
	public int scoreNull = 0; 

	// Use this for initialization
	void Start () {

		GameObject = transform;

	}

	// Update is called once per frame
	void Update () {
		//direzione fissa
    	if (ScoreScript.score <=25) {
			transform.Translate (-0.1f, 0f, 0f);
		} else if (ScoreScript.score <=49) {
			transform.Translate (-0.11f, 0f, 0f);
		} else if (ScoreScript.score <= 99) {
			transform.Translate (-0.12f, 0f, 0f);
		} else if (ScoreScript.score >= 100) {
			transform.Translate (-0.13f, 0f, 0f);
		} 

		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
			//spostamento a sinistra

			if (transform.position.z > 1.03) {
				Vector3 tempPos = transform.position;
				tempPos.z = -1f;
				transform.position = tempPos;
						ScoreScript.score += scoreValue;
				}
			//spostamento a destra

				else if (transform.position.z <-0.9) {
				Vector3 tempPos = transform.position;
				tempPos.z = 1.04f;
				transform.position = tempPos;
					ScoreScript.score += scoreValue;
				}
				
			}

		//rotazione a destra
		if(transform.position.z >1.03){
			Sphere.transform.Rotate (new Vector3 (0f, 1f, 0f), -5);
		}
		//rotazione a sinistra
		else if(transform.position.z <-0.9){
			Sphere.transform.Rotate (new Vector3 (0f, 1f, 0f), 5);
		}

		BestScore.Best.CheckHighScore ();
		PowerUpScore.Power.CheckHighScore ();



//		//Input for PC
//
////		score for PC
//		if (Input.GetKeyDown (KeyCode.A)) {
//			if(transform.position.z >1.03){
//				ScoreScript.score += scoreValue;
//			}
//			else if (transform.position.z <-0.9) {
//					ScoreScript.score += scoreNull;
//				}
//			
//		}
//
//		if (Input.GetKeyDown (KeyCode.D)) {
//			if(transform.position.z <-0.9){
//				ScoreScript.score += scoreValue;
//			}
//			else if (transform.position.z >1.03) {
//				ScoreScript.score += scoreNull;
//			}
//			
//		}
//
//		//spostamento a sinistra
//		if (Input.GetKey (KeyCode.A)) {
//			Vector3 tempPos = transform.position;
//			tempPos.z = -1f;
//			transform.position = tempPos;
//
//		}
//
//		//spostamento a destra
//		if (Input.GetKey (KeyCode.D)) {
//			Vector3 tempPos = transform.position;
//			tempPos.z = 1.04f;
//			transform.position = tempPos;
//			
//		}
	}


}