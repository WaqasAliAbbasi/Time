using UnityEngine;
using System.Collections;

public class ShowInfo : MonoBehaviour {

	public GameObject info;
	public static int progress = 0;
	public AudioSource audiotoplay;
	public bool alreadyvisited = false;
	private Synchronisation sync;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void showinfo () {
		sync = FindObjectOfType<Synchronisation> ();
		info.SetActive (true);
		audiotoplay.Play ();
		if (!alreadyvisited) {
			++progress;
			alreadyvisited = true;
			sync.handlesync (audiotoplay);
		}
	}
}
