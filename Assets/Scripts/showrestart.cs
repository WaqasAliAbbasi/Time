using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class showrestart : MonoBehaviour {
	private AudioSource audiotoplay;
	public GameObject restart;
	// Use this for initialization
	void Start () {
		audiotoplay = GetComponent<AudioSource>();
		StartCoroutine(waitBeforeFinish(audiotoplay.clip.length));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator waitBeforeFinish (float time) {
		yield return new WaitForSeconds (time);
		restart.SetActive (true);	
	}
}
