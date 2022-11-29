using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {
	public AudioClip[] stings;
	public AudioSource stingSource;

	// Use this for initialization
	void Start () {
		int randClip = Random.Range (0, 3);
		stingSource.clip = stings[randClip];
		stingSource.Play();
	}
	
	// Update is called once per frame
	void Update () {

		if (!stingSource.isPlaying) {
			int randClip = Random.Range (0, 3);
			stingSource.clip = stings[randClip];
			stingSource.Play();
		}
	}
}
