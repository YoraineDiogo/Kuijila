using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dragHand : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
	public static GameObject itemBeingDragged;
	public static GameObject itemABeingDragged;
	Vector3 startPosition;
	Transform startParent;

	public void OnBeginDrag (PointerEventData eventData){
		itemBeingDragged = gameObject;
		itemABeingDragged = gameObject;
		startPosition = transform.position;
		startParent = transform.parent;
		GetComponent<CanvasGroup>().blocksRaycasts = false;
	}
	
	public void OnDrag (PointerEventData eventData){
		transform.position = Input.mousePosition;
	}

	public void OnEndDrag (PointerEventData eventData){
		
		itemBeingDragged = null;
		itemABeingDragged = null;
		GetComponent<CanvasGroup>().blocksRaycasts = true;
		if(transform.parent != startParent){
			transform.position = startPosition;
		}
	}
	
}
