using UnityEngine;
using System.Collections;

public class GoDown : MonoBehaviour {

	public GameObject cam;
	public float fract;
	private int startDown;
	public GameObject shutdown1;
	public GameObject start1;
	public GameObject start2;
	public AudioSource ladderSound;

	// Use this for initialization
	void Start () {
		cam.transform.position = new Vector3 (4.12f,-4.68f,20.55f);
		startDown = 0;
		ladderSound.Play ();
	}

	// Update is called once per frame
	void Update () {

		if (startDown == 1) {
			cam.transform.position = new Vector3 (4.12f,-4.68f,20.55f);
			startDown = 0;
		}

		if (cam.transform.position.y < -20f) {
			shutdown1.SetActive (false);
			start1.SetActive (true);
			start2.SetActive (true);
		}
		//Vector3 target = new Vector3 (4.12f,-26.73f,20.63f);
		//cam.transform.position = Vector3.Lerp (cam.transform.position, target, fract);
		if (cam.transform.position.y > -25f) {
			cam.transform.position = new Vector3 (cam.transform.position.x, cam.transform.position.y - fract, cam.transform.position.z);
		} else if (cam.transform.position.y <= -25f) {
			cam.transform.position = new Vector3 (4.5529f,-26.32f,19.133f);
			GetComponent<GoDown>().enabled = false;
			startDown = 1;
			ladderSound.Stop ();
		}
	}
}
