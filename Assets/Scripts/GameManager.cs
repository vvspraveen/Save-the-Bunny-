using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	bool gameOver=false;
	int score=0;

	public GameObject gameOverPanel;
	public GameObject Leftclick;
	public GameObject Rightclick;
	public GameObject audio;

	public Text scoreText;
	public Text scoreTextPanel;

	private void Awake()
	{
		if (instance == null) {
			instance = this;
		}
	}

	public void GameOver()
	{
		gameOver = true;
		GameObject.Find ("EnemySpawn").GetComponent<EnemySpawner>().StopSpawning();
		scoreTextPanel.text = "Score: " + score;
		gameOverPanel.SetActive (true);
		Leftclick.SetActive (false);
		Rightclick.SetActive (false);
		audio.SetActive (false);


	}
	public void IncrementScore()
	{
		if (!gameOver)
		{
			score++;
			print (score);
			scoreText.text = score.ToString();

		}

	}

	public void MainMenu()
	{
		SceneManager.LoadScene("Menu");
	}
	public void Restart()
	{
		SceneManager.LoadScene("Game");
	}

}
