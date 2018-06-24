using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
	private Text _scoreText;
	private int _score = 0;

	private static ScoreTracker instance;
	public static ScoreTracker Instance
	{
		get
		{
			return instance;
		}
	}

	protected void Awake()
	{
		DontDestroyOnLoad(this);
		if (instance == null)
			instance = this;
	}

	private void Start()
	{
		_scoreText = GetComponent<Text>();
	}

	public void IncrementScore()
	{
		_score++;
		UpdateText();
	}

	private void UpdateText()
	{
		_scoreText.text = string.Format("Score: {0}", _score);
	}
}
