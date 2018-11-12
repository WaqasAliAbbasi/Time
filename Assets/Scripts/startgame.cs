using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class startgame : MonoBehaviour {
	private AudioSource audiotoplay;
	// Use this for initialization
	void Start () {
		audiotoplay = GetComponent<AudioSource>();
		StartCoroutine(waitBeforeFinish(audiotoplay.clip.length));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void skip () {
		SceneManager.LoadScene ("Scene1");
	}

	IEnumerator waitBeforeFinish (float time) {
		yield return new WaitForSeconds (time);
		SceneManager.LoadScene ("Scene1");	
	}
}
