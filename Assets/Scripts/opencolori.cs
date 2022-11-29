using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;
public class opencolori : MonoBehaviour {
	public GameObject Panel;
	public Material ball;
	public Texture textball1;
	public Texture textball2;
	public Texture textball3;
	public Texture textball4;
	public Texture textball5;
	public Texture textball6;
	public Texture textball7;
	public Texture textball8;
	public Texture textball9;
	public Texture textball10;
	static int buy2;
	static int buy3;
	static int buy4;
	static int buy5;
	static int buy6;
	static int buy7;
	static int buy8;
	static int buy9;
	static int buy10;
	public static int color;
	public GameObject prezzo;
	public GameObject prezzo3;
	public GameObject prezzo4;
	public GameObject prezzo5;
	public GameObject prezzo6;
	public GameObject prezzo7;
	public GameObject prezzo8;
	public GameObject prezzo9;
	public GameObject prezzo10;
	public GameObject image;
	public GameObject image3;
	public GameObject image4;
	public GameObject image5;
	public GameObject image6;
	public GameObject image7;
	public GameObject image8;
	public GameObject image9;
	public GameObject image10;
	public Button button1;
	public Button button2;
	public Button button3;
	public Button button4;
	public Button button5;
	public Button button6;
	public Button button7;
	public Button button8;
	public Button button9;
	public Button button10;


		// Use this for initialization
	void Start () {

		opencolori.color = PlayerPrefs.GetInt("color", 0);
		if (opencolori.color == 1) {
			ball.mainTexture = textball1;
			button1.Select();
		}
		
		else if (opencolori.color == 2) {
			ball.mainTexture = textball2;
			button2.Select();
		}

		else if (opencolori.color == 3) {
			ball.mainTexture = textball3;
			button3.Select();
		}

		else if (opencolori.color == 4) {
			ball.mainTexture = textball4;
			button4.Select();
		}

		else if (opencolori.color == 5) {
			ball.mainTexture = textball5;
			button5.Select();
		}

		else if (opencolori.color == 6) {
			ball.mainTexture = textball6;
			button6.Select();
		}

		else if (opencolori.color == 7) {
			ball.mainTexture = textball7;
			button7.Select();
		}

		else if (opencolori.color == 8) {
			ball.mainTexture = textball8;
			button8.Select();
			
		}

		else if (opencolori.color == 9) {
			ball.mainTexture = textball9;
			button9.Select();

		}

		else if (opencolori.color == 10) {
			ball.mainTexture = textball10;
			button10.Select();
			
		}


		buy2 = PlayerPrefs.GetInt("buy2", 0);
		if (buy2 == 1) {
			prezzo.SetActive (false);
			image.SetActive (true);
		}
		buy3 = PlayerPrefs.GetInt("buy3", 0);
		if (buy3 == 1) {
			prezzo3.SetActive (false);
			image3.SetActive (true);
		}
		buy4 = PlayerPrefs.GetInt("buy4", 0);
		if (buy4 == 1) {
			prezzo4.SetActive (false);
			image4.SetActive (true);
		}
		buy5 = PlayerPrefs.GetInt("buy5", 0);
		if (buy5 == 1) {
			prezzo5.SetActive (false);
			image5.SetActive (true);
		}
		buy6 = PlayerPrefs.GetInt("buy6", 0);
		if (buy6 == 1) {
			prezzo6.SetActive (false);
			image6.SetActive (true);
		}
		buy7 = PlayerPrefs.GetInt("buy7", 0);
		if (buy7 == 1) {
			prezzo7.SetActive (false);
			image7.SetActive (true);
		}
		buy8 = PlayerPrefs.GetInt("buy8", 0);
		if (buy8 == 1) {
			prezzo8.SetActive (false);
			image8.SetActive (true);
		}
		buy9 = PlayerPrefs.GetInt("buy9", 0);
		if (buy9 == 1) {
			prezzo9.SetActive (false);
			image9.SetActive (true);
		}
		buy10 = PlayerPrefs.GetInt("buy10", 0);
		if (buy10 == 1) {
			prezzo10.SetActive (false);
			image10.SetActive (true);
		}
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Click (){
		Panel.SetActive (true);
	}
	public void Back (){
		Panel.SetActive (false);
	}

	public void ball1 (){
		ball.mainTexture = textball1;
		color = 1;
		PlayerPrefs.SetInt("color", color);

	}
	 public void ball2 (){

		buy2 = PlayerPrefs.GetInt("buy2", 0);
        if (buy2 == 1) {
			ball.mainTexture = textball2;
			color=2;
			PlayerPrefs.SetInt("color", color);

		}

	else if (PowerUpScore.powerScore >= 100) {
			prezzo.SetActive (false);
			image.SetActive (true);

		    PowerUpScore.powerScore -= 100;
			ball.mainTexture = textball2;
			buy2 = 1;
		    PlayerPrefs.SetInt("PowerScore1", PowerUpScore.powerScore);
			PlayerPrefs.SetInt("buy2", buy2);
			color=2;
			PlayerPrefs.SetInt("color", color);
          }
	}
	public void ball3 (){
		
		buy3 = PlayerPrefs.GetInt("buy3", 0);
		if (buy3 == 1) {
			ball.mainTexture = textball3;
			color=3;
			PlayerPrefs.SetInt("color", color);
			
		}
		
		else if (PowerUpScore.powerScore >= 100) {
			prezzo3.SetActive (false);
			image3.SetActive (true);
			
			PowerUpScore.powerScore -= 100;
			ball.mainTexture = textball3;
			buy3 = 1;
			PlayerPrefs.SetInt("PowerScore1", PowerUpScore.powerScore);
			PlayerPrefs.SetInt("buy3", buy3);
			color=3;
			PlayerPrefs.SetInt("color", color);
		}
	}
	public void ball4 (){
		
		buy4 = PlayerPrefs.GetInt("buy4", 0);
		if (buy4 == 1) {
			ball.mainTexture = textball4;
			color=4;
			PlayerPrefs.SetInt("color", color);
			
		}
		
		else if (PowerUpScore.powerScore >= 100) {
			prezzo4.SetActive (false);
			image4.SetActive (true);
			
			PowerUpScore.powerScore -= 100;
			ball.mainTexture = textball4;
			buy4 = 1;
			PlayerPrefs.SetInt("PowerScore1", PowerUpScore.powerScore);
			PlayerPrefs.SetInt("buy4", buy4);
			color=4;
			PlayerPrefs.SetInt("color", color);
		}
	}
	public void ball5 (){
		
		buy5 = PlayerPrefs.GetInt("buy5", 0);
		if (buy5 == 1) {
			ball.mainTexture = textball5;
			color=5;
			PlayerPrefs.SetInt("color", color);
			
		}
		
		else if (PowerUpScore.powerScore >= 100) {
			prezzo5.SetActive (false);
			image5.SetActive (true);
			
			PowerUpScore.powerScore -= 100;
			ball.mainTexture = textball5;
			buy5 = 1;
			PlayerPrefs.SetInt("PowerScore1", PowerUpScore.powerScore);
			PlayerPrefs.SetInt("buy5", buy5);
			color=5;
			PlayerPrefs.SetInt("color", color);
		}
	}
	public void ball6 (){
		
		buy6 = PlayerPrefs.GetInt("buy6", 0);
		if (buy6 == 1) {
			ball.mainTexture = textball6;
			color=6;
			PlayerPrefs.SetInt("color", color);
			
		}
		
		else if (PowerUpScore.powerScore >= 100) {
			prezzo6.SetActive (false);
			image6.SetActive (true);
			
			PowerUpScore.powerScore -= 100;
			ball.mainTexture = textball6;
			buy6 = 1;
			PlayerPrefs.SetInt("PowerScore1", PowerUpScore.powerScore);
			PlayerPrefs.SetInt("buy6", buy6);
			color=6;
			PlayerPrefs.SetInt("color", color);
		}
	}
	public void ball7 (){
		
		buy7 = PlayerPrefs.GetInt("buy7", 0);
		if (buy7 == 1) {
			ball.mainTexture = textball7;
			color=7;
			PlayerPrefs.SetInt("color", color);
			
		}
		
		else if (PowerUpScore.powerScore >= 100) {
			prezzo7.SetActive (false);
			image7.SetActive (true);
			
			PowerUpScore.powerScore -= 100;
			ball.mainTexture = textball7;
			buy7 = 1;
			PlayerPrefs.SetInt("PowerScore1", PowerUpScore.powerScore);
			PlayerPrefs.SetInt("buy7", buy7);
			color=7;
			PlayerPrefs.SetInt("color", color);
		}
	}
	public void ball8 (){
		
		buy8 = PlayerPrefs.GetInt("buy8", 0);
		if (buy8 == 1) {
			ball.mainTexture = textball8;
			color=8;
			PlayerPrefs.SetInt("color", color);
			
		}
		
		else if (PowerUpScore.powerScore >= 100) {
			prezzo8.SetActive (false);
			image8.SetActive (true);
			
			PowerUpScore.powerScore -= 100;
			ball.mainTexture = textball8;
			buy8 = 1;
			PlayerPrefs.SetInt("PowerScore1", PowerUpScore.powerScore);
			PlayerPrefs.SetInt("buy8", buy8);
			color=8;
			PlayerPrefs.SetInt("color", color);
		}
	}
	public void ball9 (){
		
		buy9 = PlayerPrefs.GetInt("buy9", 0);
		if (buy9 == 1) {
			ball.mainTexture = textball9;
			color=9;
			PlayerPrefs.SetInt("color", color);
			
		}
		
		else if (PowerUpScore.powerScore >= 100) {
			prezzo9.SetActive (false);
			image9.SetActive (true);
			
			PowerUpScore.powerScore -= 100;
			ball.mainTexture = textball9;
			buy9 = 1;
			PlayerPrefs.SetInt("PowerScore1", PowerUpScore.powerScore);
			PlayerPrefs.SetInt("buy9", buy9);
			color=9;
			PlayerPrefs.SetInt("color", color);
		}
	}
	public void ball10 (){
		
		buy10 = PlayerPrefs.GetInt("buy10", 0);
		if (buy10 == 1) {
			ball.mainTexture = textball10;
			color=10;
			PlayerPrefs.SetInt("color", color);
			
		}
		
		else if (PowerUpScore.powerScore >= 100) {
			prezzo10.SetActive (false);
			image10.SetActive (true);
			
			PowerUpScore.powerScore -= 100;
			ball.mainTexture = textball10;
			buy10 = 1;
			PlayerPrefs.SetInt("PowerScore1", PowerUpScore.powerScore);
			PlayerPrefs.SetInt("buy10", buy10);
			color=10;
			PlayerPrefs.SetInt("color", color);
		}
	}
}
