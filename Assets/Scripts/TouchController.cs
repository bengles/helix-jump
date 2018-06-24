using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchController : MonoBehaviour, IPointerClickHandler, IDragHandler
{
	public static event Action<PointerEventData> OnDragEvent;
	public static event Action<PointerEventData> OnPointerClickEvent;

	public void OnDrag(PointerEventData eventData)
	{
		if (OnDragEvent != null)
		{
			OnDragEvent(eventData);
		}
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		if (OnPointerClickEvent != null)
		{
			OnPointerClickEvent(eventData);
		}
	}
}
