using UnityEngine;
using System.Collections;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
public class GoogleService : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Leaderboard() {
		if (Social.localUser.authenticated) {
			((PlayGamesPlatform)Social.Active).ShowLeaderboardUI ("TokenID");
		} else {
			Social.localUser.Authenticate((bool success) => {
				// handle success or failure
				if (success)
				{
					((PlayGamesPlatform)Social.Active).ShowLeaderboardUI ("TokenID");
					Debug.Log("You've successfully logged in");
				}
				else
				{
					Debug.Log("Login failed for some reason");
				}
			});
		}
	}

	public void Achievements (){
		if (Social.localUser.authenticated) {
			Social.ShowAchievementsUI();
		} else {
			Social.localUser.Authenticate((bool success) => {
				// handle success or failure
				if (success)
				{
					Social.ShowAchievementsUI();
					Debug.Log("You've successfully logged in");
				}
				else
				{
					Debug.Log("Login failed for some reason");
				}
			});
		}
	}
}