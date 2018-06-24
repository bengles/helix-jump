using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementScript : MonoBehaviour
{
	[SerializeField]
	private Transform Ball;

	private Vector3 _originalPosition;

	void Start()
	{
		_originalPosition = this.transform.position; ;
	}

	public void Reset()
	{
		this.transform.position = _originalPosition;
	}

	// Update is called once per frame
	void LateUpdate()
	{
		if (transform.position.y - Ball.position.y > 2)
		{
			transform.position = new Vector3(transform.position.x, Ball.position.y + 2, transform.position.z);
		}
	}
}
