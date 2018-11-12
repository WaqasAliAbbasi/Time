using UnityEngine;
using System.Collections;

public class startGoingDown : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider coll) {
		GetComponent<GoDown> ().enabled = true;
	}
}
