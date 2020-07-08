using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerSun : MonoBehaviour
{
	private static GameProgress gameProgress;

	private void Start()
	{
		gameProgress = FindObjectOfType<GameProgress>();
	}

	private void OnTriggerEnter(Collider other)
	{
		SceneManager.LoadScene("StartScene");
		gameProgress.InterpolationTime = 0;
		gameProgress.InGame = false;
	}
}
