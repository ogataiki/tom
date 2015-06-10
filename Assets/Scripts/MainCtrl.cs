using UnityEngine;
using System.Collections;
using TouchScript.Gestures;

public class MainCtrl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.Find ("GameMgr").GetComponent<PressGesture>().Pressed += HandlePressed;
		GameObject.Find ("GameMgr").GetComponent<TapGesture>().Tapped += HandleTapped;
	}

	void HandlePressed (object sender, System.EventArgs e)
	{
		var gesture = sender as PressGesture;

		if(gesture.ActiveTouches.Count == 1) {
			Debug.Log ("Touch!");
		}
	}

	void HandleTapped (object sender, System.EventArgs e)
	{
		var gesture = sender as TapGesture;

		Debug.Log ("TouchEnd!");
	}

	// Update is called once per frame
	void Update () {
		
	}
}
