using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
	private GameObject Player;
	private GameObject GameManager;
	private GameProgress WinCondition;

	public Transform playerPos;
	public Transform spawnPos;

	private bool Wasted = false;
	public float PlayerHP = 100;

	void Start()
    {
		Player = gameObject;
		GameManager = GameObject.Find("GameManager");
		WinCondition = GameManager.GetComponent<GameProgress>();
    }

    void Update()
    {
		HealthStatus();
    }

	private void HealthStatus()
	{
		if (PlayerHP <= 0)
		{
			Wasted = true;
		}
		if (Wasted == true)
		{
			Death();
			Wasted = false;
		}
	}

	public void Death()
	{
		playerPos.transform.position = spawnPos.transform.position;
		GetComponent<Rigidbody>().velocity = Vector3.zero;
		ResetStats();
	}

	void ResetStats()
	{
		PlayerHP = 100;
		WinCondition.GameScore = WinCondition.TotalScore;
	}
}
