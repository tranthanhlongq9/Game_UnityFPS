using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerSurvivalMap : MonoBehaviour {
	public GameObject startupText;
	public GameObject enemySpawner;

	void Start() {
		startupText.SetActive(true);
		Invoke("ActivateSpawner", 60);
	}

	void ActivateSpawner() {
		enemySpawner.SetActive(true);
	}
}
