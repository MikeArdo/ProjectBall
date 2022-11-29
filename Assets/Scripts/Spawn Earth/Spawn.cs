using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
	public float lifetime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerExit (Collider other) {
		if (other.tag == "sphere") {
//			SpawnManager.Instance.SpawnTile();
			Destroy (gameObject, lifetime);
		}
	}
	void OnTriggerEnter (Collider other) {
		if (other.tag == "sphere") {
			SpawnManager.Instance.SpawnTile();
//			Destroy (gameObject, lifetime);
		}
	}

}
