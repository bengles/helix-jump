using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithBall : MonoBehaviour
{

	[SerializeField]
	private Transform _ball;

	// Update is called once per frame
	void Update()
	{
		this.transform.position = new Vector3(0, _ball.position.y, 0);

	}
}
