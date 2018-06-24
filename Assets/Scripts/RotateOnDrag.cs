using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateOnDrag : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		TouchController.OnDragEvent += OnDrag;
	}

	private void OnDrag(PointerEventData eventData)
	{
		transform.Rotate(Vector3.up, -eventData.delta.x);
	}
}
