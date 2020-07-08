using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWater : MonoBehaviour
{
	GameObject Player;
	PlayerRespawn RespawnScript;

	bool Suffering; 

	void Start()
    {
		Player = GameObject.Find("Player");
		RespawnScript = Player.GetComponent<PlayerRespawn>();
	}

	void Update()
    {
		if (Suffering == true)
		{
			RespawnScript.PlayerHP--;
		}
    }

	private void OnTriggerEnter(Collider other)
	{
		Suffering = true;
	}

	private void OnTriggerExit(Collider other)
	{
		Suffering = false;
	}
}
