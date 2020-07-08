using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartCanvas : MonoBehaviour
{
	private Canvas startCanvas;

	private GameProgress gameProgress;
	private Text GameScore;
	private Text MenuControls;


	void Start()
    {
		startCanvas = FindObjectOfType<Canvas>();
		gameProgress = GameObject.Find("GameManager").GetComponent<GameProgress>();

		DontDestroyOnLoad(gameProgress);

		GameScore = GameObject.Find("Score").GetComponent<Text>();
		MenuControls = GameObject.Find("Controls").GetComponent<Text>();

		startCanvas.worldCamera = Camera.main;
	}

	void Update()
    {
		if (gameProgress.DisplayScore == true)
		{
			GameScore.text = "Your Total Score: " + gameProgress.GameScore;
		}

		MenuControls.text = "Press 'Escape' to Exit                                          Press 'Enter' to play";

		if (gameProgress.InGame == false)
		{
			if (Input.GetKeyUp(KeyCode.Return))
			{
				SceneManager.LoadScene("RetroVape");
				gameProgress.GameScore = 25;
				gameProgress.InGame = true;
			}

			if (Input.GetKeyUp(KeyCode.Escape))
			{
				Application.Quit();
			}
		}
	}
}
