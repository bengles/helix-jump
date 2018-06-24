using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawner : MonoBehaviour
{

	[SerializeField]
	private GameObject _level;
	private List<GameObject> _levels;
	[SerializeField]
	private Transform _ball;

	private int _counter = 1;

	private Color _color;

	// Use this for initialization
	void Start()
	{
		UnityEngine.Random.InitState((int)DateTime.Now.Ticks);
		_color = new Color(UnityEngine.Random.Range(0f, 1f),
			UnityEngine.Random.Range(0f, 1f),
			UnityEngine.Random.Range(0f, 1f));
		_levels = new List<GameObject>();
		while (_levels.Count < 20)
		{
			SpawnLevel();
		}
	}

	// Update is called once per frame
	void Update()
	{
		foreach (GameObject go in _levels)
		{
			if (go.transform.position.y > _ball.position.y + 3)
			{
				go.transform.position = new Vector3(0, -3 * (_levels.Count + _counter), 0);
				go.transform.localRotation = Quaternion.Euler(0, UnityEngine.Random.Range(0, 360), 0);
				go.GetComponent<MeshRenderer>().material.color = _color;
				_counter++;
			}
			if (_counter % 10 == 0)
			{
				_color = new Color(UnityEngine.Random.Range(0f, 1f),
					UnityEngine.Random.Range(0f, 1f),
					UnityEngine.Random.Range(0f, 1f));
			}
		}
	}

	private void SpawnLevel()
	{
		GameObject go = Instantiate(_level);
		go.GetComponent<Level>()._ball = _ball;
		go.transform.SetParent(this.transform);
		go.transform.position = new Vector3(0, -3 * _levels.Count, 0);
		go.GetComponent<MeshRenderer>().material.color = _color;
		go.transform.localRotation = Quaternion.Euler(0, UnityEngine.Random.Range(0, 360), 0);
		_levels.Add(go);
	}
}
