using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class panelScript : MonoBehaviour{

	public GameObject Panel;
	int counter;
	
	public void showhiddenPanel(){
	
		counter++;
		if(counter%2==1)
		{
			Panel.gameObject.SetActive (true);
		} else {
			Panel.gameObject.SetActive (false);
		}
	}

}