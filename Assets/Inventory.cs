using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Inventory : MonoBehaviour, IHasChanged {
	[SerializeField] Transform slots;
	[SerializeField] Text inventoryText;
	[SerializeField] Text inventText;
	// Use this for initialization
	void Start () {
		HasChanged();
	}
	public void HasChanged ()
	{
		System.Text.StringBuilder builder = new System.Text.StringBuilder();
		builder.Append(" - ");
		foreach (Transform slotTransform in slots){
			GameObject item = slotTransform.GetComponent<slot>().item;
			if(item){
				builder.Append (item.name);
				builder.Append("");
			}	
		}
		inventoryText.text = builder.ToString ();
		foreach (Transform slotTransform in slots){
			GameObject itemA = slotTransform.GetComponent<slot>().itemA;
			if(itemA){
				builder.Append (itemA.name);
				builder.Append("");
			}
		}
		inventText.text = builder.ToString ();
	}
}
namespace UnityEngine.EventSystems{		
	public interface IHasChanged : IEventSystemHandler{
		void HasChanged();	
	}
}