using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public GameObject startupText;
	public GameObject enemySpawner;

	void Start() {
		startupText.SetActive(true);
		Invoke("ActivateSpawner", 31);
	}

	void ActivateSpawner() {
		enemySpawner.SetActive(true);
	}
}
