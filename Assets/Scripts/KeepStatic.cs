using UnityEngine;
using System.Collections;

public class KeepStatic : MonoBehaviour {

	public GameObject cam;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		cam.transform.position = new Vector3(0f,1f,-10f);
		cam.transform.Rotate(0f,0f,0f);
	}
}
