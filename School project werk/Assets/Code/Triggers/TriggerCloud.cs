using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCloud : MonoBehaviour
{
    private GameObject Player;
    private PlayerRespawn RespawnScript;

    private bool Sufficating = false;

    private float time;
    private float InterpolationPeriod = 0.5f;

    private void Start()
    {
        Player = GameObject.Find("Player");
        RespawnScript = Player.GetComponent<PlayerRespawn>();
    }

    private void Update()
    {
        Suffication();
    }

    private void Suffication()
    {
        time += Time.deltaTime;

        if (Sufficating == true)
        {
            if (time >= InterpolationPeriod)
            {
                time = 0.0f;
                RespawnScript.PlayerHP = RespawnScript.PlayerHP - 20;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Sufficating = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Sufficating = false;
    }
}