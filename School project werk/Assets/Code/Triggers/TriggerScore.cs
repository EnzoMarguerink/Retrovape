using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScore : MonoBehaviour
{
	GameObject GameManager;
	GameProgress WinCondition;

	void Start()
	{
		GameManager = GameObject.Find("GameManager");
		WinCondition = GameManager.GetComponent<GameProgress>();
	}

	private void OnTriggerEnter(Collider other)
	{
		WinCondition.GameScore--;
	}
}
