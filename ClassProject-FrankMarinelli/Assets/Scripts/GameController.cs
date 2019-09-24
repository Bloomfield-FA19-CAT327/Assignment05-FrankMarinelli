using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public float counterTime;
	public Text counterText;

	private void Update() {
		counterTime += Time.deltaTime;
		counterText.text = "Time: " + Mathf.Round(counterTime).ToString();
	}
	//code used is from a previous project from a different class. Its changed around for this assignment.

	private void OnTriggerEnter(Collider other) {
		if (GameObject.FindGameObjectWithTag("Enemy")) {
			
		}
		if (GameObject.FindGameObjectWithTag("Win")) {

		}
	}


}