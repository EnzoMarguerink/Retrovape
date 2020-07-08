using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObstacle : MonoBehaviour
{
	GameObject Player;
	PlayerRespawn RespawnScript;

	void Start()
	{
		Player = GameObject.Find("Player");
		RespawnScript = Player.GetComponent<PlayerRespawn>();
	}

	private void OnTriggerEnter(Collider other)
	{
		RespawnScript.PlayerHP = 0;
	}
}
