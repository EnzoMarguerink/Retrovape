using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHUD : MonoBehaviour
{
	GameObject Player;
	GameObject GameManager;
	Canvas HUD;

	PlayerRespawn RespawnScript;
	GameProgress gameProgress;

	Text HealthPoints;
	Text GameScore;
	Text GameControls;

    void Start()
    {
		Player = GameObject.Find("Player");
		GameManager = GameObject.Find("GameManager");
		HUD = FindObjectOfType<Canvas>();

		HealthPoints = GameObject.Find("Health").GetComponent<Text>();
		GameScore = GameObject.Find("Score").GetComponent<Text>();
		GameControls = GameObject.Find("GameControls").GetComponent<Text>();

		RespawnScript = Player.GetComponent<PlayerRespawn>();
		gameProgress = GameManager.GetComponent<GameProgress>();

		HUD.worldCamera = Camera.main;
    }

    void Update()
    {
		if (gameProgress.InGame == true)
		{
			gameProgress.InterpolationTime = gameProgress.InterpolationTime + Time.deltaTime;
		}


		HealthPoints.text = "Health: " + RespawnScript.PlayerHP;
		GameScore.text = "Score: " + gameProgress.GameScore + "/" + gameProgress.TotalScore;
		if (gameProgress.InterpolationTime <= 3)
		{
			GameControls.text = "Press 'Space' to elevate";
		}
	}
}
