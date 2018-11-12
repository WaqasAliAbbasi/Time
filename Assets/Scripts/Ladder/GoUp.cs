using UnityEngine;
using System.Collections;

public class GoUp : MonoBehaviour {public GameObject cam;
	public float fract;
	private int startUp;
	public GameObject shutdown1;
	public GameObject start1;
	public GameObject shutdown2;
	public AudioSource ladderSound;

	// Use this for initialization
	void Start () {
		cam.transform.position = new Vector3 (4.12f,-23f,20.55f);
		startUp = 0;
		ladderSound.Play ();
		shutdown1.SetActive (false);
		shutdown2.SetActive (false);
		start1.SetActive (true);
	}

	// Update is called once per frame
	void Update () {

		if (startUp == 1) {
			cam.transform.position = new Vector3 (4.12f,-23f,20.55f);
			startUp = 0;
		}

		//Vector3 target = new Vector3 (4.12f,-26.73f,20.63f);
		//cam.transform.position = Vector3.Lerp (cam.transform.position, target, fract);
		if (cam.transform.position.y < -4.68f) {
			cam.transform.position = new Vector3 (cam.transform.position.x, cam.transform.position.y + fract, cam.transform.position.z);
		} else if (cam.transform.position.y >= -4.68f) {
			cam.transform.position = new Vector3 (4.5529f,-3.61f,19.133f);
			GetComponent<GoUp> ().enabled = false;
			startUp = 1;
			ladderSound.Stop();
		}
	}
}
