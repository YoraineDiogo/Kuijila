using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class slot : MonoBehaviour, IDropHandler {
	public GameObject item{
		get{
			
			if(transform.childCount>0){
				return transform.GetChild(0).gameObject;
			}
			
			return null;
		}
	}
	
	public GameObject itemA{
		get{
			if(transform.childCount>0){
				return transform.GetChild(0).gameObject;
			}
			return null;
		}
	}
	//iDrop implementation
	public void OnDrop (PointerEventData eventData){
		
		if(!item){
			dragHand.itemBeingDragged.transform.SetParent (transform);
			ExecuteEvents.ExecuteHierarchy<IHasChanged>(gameObject, null,(x,y) => x.HasChanged());
		}
		
		if(!itemA){
			dragHand.itemABeingDragged.transform.SetParent (transform);
			ExecuteEvents.ExecuteHierarchy<IHasChanged>(gameObject, null,(x,y) => x.HasChanged());
		}
	}
	//endRegion
}
