using UnityEngine;
using System.Collections;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
using GoogleMobileAds.Api;
public class PlayGames : MonoBehaviour {
	static int login;
	// Use this for initialization
	void Start () {
		// Activate the Google Play Games platform
		PlayGamesPlatform.Activate();
		RequestBanner ();
		if (login == 1) {
		}
		else {
			Social.localUser.Authenticate((bool success) => {
				// handle success or failure
				if (success)
				{
					Debug.Log("You've successfully logged in");
				}
				else
				{
					Debug.Log("Login failed for some reason");
				}
			});
			login=1;
		}

	}
	
	// Update is called once per frame
	void Update () {
		if (Social.localUser.authenticated)
		{
			Social.ReportScore(BestScore.highScore, "TokenID", (bool success) =>
			                   {
				
			});
		}
		
		if (Social.localUser.authenticated) {
			if (BestScore.highScore >= 10) {
				
				Social.ReportProgress ("TokenID", 100.0f, (bool success) =>
				                       {
					if (success) {
						Debug.Log ("You've successfully logged in");
					} else {
						Debug.Log ("Login failed for some reason");
					}
				});
			}
		}
		
		if (Social.localUser.authenticated) {
			if (BestScore.highScore >= 50) {
				
				Social.ReportProgress ("TokenID", 100.0f, (bool success) =>
				                       {
					if (success) {
						Debug.Log ("You've successfully logged in");
					} else {
						Debug.Log ("Login failed for some reason");
					}
				});
			}
		}
		if (Social.localUser.authenticated) {
			if (BestScore.highScore >= 100) {
				
				Social.ReportProgress ("TokenID", 100.0f, (bool success) =>
				                       {
					if (success) {
						Debug.Log ("You've successfully logged in");
					} else {
						Debug.Log ("Login failed for some reason");
					}
				});
			}
		}
		if (Social.localUser.authenticated) {
			if (BestScore.highScore >= 200) {
				
				Social.ReportProgress ("TokenID", 100.0f, (bool success) =>
				                       {
					if (success) {
						Debug.Log ("You've successfully logged in");
					} else {
						Debug.Log ("Login failed for some reason");
					}
				});
			}
		}
		
		if (Social.localUser.authenticated) {
			if (BestScore.highScore >= 500) {
				
				Social.ReportProgress ("TokenID", 100.0f, (bool success) =>
				                       {
					if (success) {
						Debug.Log ("You've successfully logged in");
					} else {
						Debug.Log ("Login failed for some reason");
					}
				});
			}
		}
	}
	private void RequestBanner()
	{

		
		// Create a 320x50 banner at the top of the screen.
		BannerView bannerView = new BannerView("ca-app-pub-TokenADS", AdSize.Banner, AdPosition.Bottom);
		// Create an empty ad request.

		AdRequest request = new AdRequest.Builder()
			.AddTestDevice(AdRequest.TestDeviceSimulator)       // Simulator.
				.AddTestDevice("DeviceID")
				.AddTestDevice("DeviceID")  // My test device.
				.Build();
		bannerView.LoadAd(request);
	}
}
