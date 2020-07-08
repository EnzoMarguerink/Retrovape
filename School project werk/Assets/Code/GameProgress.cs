using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameProgress : MonoBehaviour
{
	public float TotalScore = 25;
	public float GameScore = 25;

	public float InterpolationTime;

	public bool InGame;
	public bool DisplayScore;

	private void Start()
	{
		Cursor.visible = false;
	}

	void Update()
    {
		if (InGame == true)
		{
			DisplayScore = true;
		}

		if (InGame == true)
		{
			if (Input.GetKeyUp(KeyCode.Escape))
			{
				SceneManager.LoadScene("StartScene");
				InterpolationTime = 0;
				InGame = false;
			}
		}
    }
}
