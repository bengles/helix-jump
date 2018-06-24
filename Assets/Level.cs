using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{

	public Transform _ball;

	private bool _scored = false;
	private Vector3 _originalPosition;

	void Start()
	{
		_originalPosition = this.transform.position;
	}

	// Update is called once per frame
	void Update()
	{
		if (this.transform.position != _originalPosition)
		{
			_scored = false;
			_originalPosition = this.transform.position;
		}

		if (_ball.position.y < transform.position.y && !_scored)
		{
			ScoreTracker.Instance.IncrementScore();
			_scored = true;
		}
	}
}