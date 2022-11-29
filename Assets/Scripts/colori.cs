using UnityEngine;
using System.Collections;

public class colori : MonoBehaviour {
	public Material rendBack;
	public Texture[] texturesBack;
	public Material rendCube;
	public Texture[] texturesCube;
	public Material rendSmallCube;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		BackGround ();
		Cube ();
		SmallCube ();
	}
	bool ok {
		get;
		set;
	}

	public void BackGround() {
		
		if (ok == false) {
			if ((ScoreScript.score % 50) == 0) {
				int randomBack = Random.Range (0, 4);
				rendBack.mainTexture = texturesBack[randomBack];
				ok=true;
			}
			
		}
		else if ((ScoreScript.score % 50) != 0) {
			ok=false;
		}
	}

	bool cube {
		get;
		set;
	}

	public void Cube() {
		
		if (cube == false) {
			if ((ScoreScript.score % 50) == 0) {
				int randomCube = Random.Range (0, 4);
				rendCube.mainTexture = texturesCube[randomCube];
				cube=true;
			}
			
		}
		else if ((ScoreScript.score % 50) != 0) {
			cube=false;
		}
	}

	bool smallcube {
		get;
		set;
	}

	public void SmallCube() {
		
		if (smallcube == false) {
			if ((ScoreScript.score % 50) == 0) {
				rendSmallCube.mainTexture = rendCube.mainTexture;
				smallcube=true;
			}
			
		}
		else if ((ScoreScript.score % 50) != 0) {
			smallcube=false;
		}
	}
}
