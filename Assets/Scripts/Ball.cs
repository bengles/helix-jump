using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ball : MonoBehaviour
{
	private Rigidbody _rigidbody;

	// Use this for initialization
	void Start()
	{
		//TouchController.OnPointerClickEvent += Reset;
		_rigidbody = GetComponent<Rigidbody>();
		UnityEngine.Random.InitState((int)DateTime.Now.Ticks);
		GetComponent<MeshRenderer>().material.color =
			new Color(UnityEngine.Random.Range(0f, 1f),
				UnityEngine.Random.Range(0f, 1f),
				UnityEngine.Random.Range(0f, 1f));
	}

	public void Reset()
	{
		_rigidbody.velocity = Vector3.zero;
		transform.position = new Vector3(0, 5, -1);
	}

	private void OnCollisionEnter()
	{
		_rigidbody.AddForce(Vector3.up * 17f, ForceMode.Impulse);
	}
}
