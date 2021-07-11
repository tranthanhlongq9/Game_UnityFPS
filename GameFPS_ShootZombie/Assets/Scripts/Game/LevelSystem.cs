﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSystem : MonoBehaviour
{
	private int level = 1;
	private int exp = 0;
	private int requireExp = 30;
	public Text levelText;
	public Text overTextLv;
	public Text expText;
	public Slider expSlider;

	void Start()
	{
		levelText = GameObject.Find("UI/InGameUI/PlayerUI/CharacterStatus/LevelText").GetComponent<Text>();

		overTextLv = GameObject.Find("UI/InGameUI/DeadScreen/LevelText").GetComponent<Text>();

		expText = GameObject.Find("UI/InGameUI/PlayerUI/CharacterStatus/ExpText").GetComponent<Text>();
		expSlider = GameObject.Find("UI/InGameUI/PlayerUI/CharacterStatus/ExpText/Slider").GetComponent<Slider>();

		UpdateUI();
	}

	void UpdateUI()
	{
		overTextLv.text = "Level: " + level;
		levelText.text = "Level: " + level;
		expText.text = "Exp: " + exp + " / " + requireExp;

		float percentage = (float)exp / (float)requireExp;
		expSlider.value = percentage;
	}

	public int GetLevel()
	{
		return level;
	}

	public void GiveExp(int amount)
	{
		exp += amount;

		CheckLevelUp();
	}

	void CheckLevelUp()
	{
		if (exp >= requireExp)
		{
			exp = exp - requireExp;
			requireExp += 30;
			level++;

			CheckLevelUp();
		}

		UpdateUI();
	}
}
