using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateHealth : MonoBehaviour {
	HealthManager healthManager;
	Text healthText;

	public Animator hitAnimator;


	void Start() {
		healthManager = GetComponent<HealthManager>();
		healthText = GameObject.Find("UI/InGameUI/PlayerUI/CharacterStatus/HealthText").GetComponent<Text>();

		healthManager.onHit.AddListener(() => { hitAnimator.SetTrigger("Show"); });
	}

	void Update() {
		if(healthText) {
			healthText.text = "HP: " + healthManager.Health.ToString();
			
		}
	}	
}
