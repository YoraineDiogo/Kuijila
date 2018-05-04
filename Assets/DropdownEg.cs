//Create a new Dropdown GameObject by going to the Hierarchy and clicking Create>UI>Dropdown. Attach this script to the Dropdown GameObject.

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Vuforia
{
public class DropdownEg : MonoBehaviour
{
    //Create a List of new Dropdown options
    List<string> m_DropOptions = new List<string> {"Portuguese", "Spanish"};
    //This is the Dropdown
    public Dropdown m_Dropdown;
	public Text selectedLanguage;
	
	public void Dropdown_IndexChanged(int index){
		
		selectedLanguage.text = m_DropOptions[index];
	}
	
    void Start()
    {
        //Fetch the Dropdown GameObject the script is attached to
     //   m_Dropdown = GetComponent<Dropdown>();
        //Clear the old options of the Dropdown menu
     //   m_Dropdown.ClearOptions();
        //Add the options created in the List above
        m_Dropdown.AddOptions(m_DropOptions);
    }
	
}
	
	/*public Camera cam;
	public Dropdown myDropdown;
	int value;
	void Update(){
		switch(myDropdown.OnValueChanged)
		{
			case 1:
				cam.backgroundColor = Color.red;
				break;
			case 2:
				cam.backgroundColor = Color.blue;
				break;
			case 3:
				cam.backgroundColor = Color.green;
				break;
			
		}
		
	}*/
}

