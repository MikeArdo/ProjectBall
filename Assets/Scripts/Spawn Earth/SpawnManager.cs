using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {
	public GameObject current;
	public GameObject[] Prefabs;
	public GameObject principal;
	public GameObject principalclone;
	private static SpawnManager instance;
	
	public static SpawnManager Instance {
		get {
			if (instance == null) {
				instance = GameObject.FindObjectOfType<SpawnManager>();
			}
			return instance;
		}
	}
	
	// Use this for initialization
	void Start () {
		for (int i=0; i < 3; i++) {
			SpawnTile ();
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
	public void SpawnTile () {
		int randomIndex = Random.Range (0, 8);
		int randomSpawn = Random.Range (0, 2);
		current = (GameObject)Instantiate (Prefabs[randomIndex], current.transform.GetChild (0).transform.GetChild (randomSpawn).position, Quaternion.identity);
		int spawnCoin = Random.Range (0, 2);
		if (spawnCoin == 0) {
			current.transform.GetChild(1).gameObject.SetActive(true);
		}
	}
	public void SpawnPrincipal () {
		principal = (GameObject)Instantiate (principalclone, principal.transform.GetChild (0).transform.GetChild (0).position, Quaternion.identity);
	}
}
