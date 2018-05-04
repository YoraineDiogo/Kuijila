/*==============================================================================
Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/
/*using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.Linq.Expressions;
using UnityEngine.Networking;

namespace Vuforia
{
    /// <summary>
    /// A custom handler that implements the ITrackableEventHandler interface.
    /// </summary>
    public class DefaultTrackableEventHandler : MonoBehaviour,
                                                ITrackableEventHandler
    {
        #region PRIVATE_MEMBER_VARIABLES
 
        private TrackableBehaviour mTrackableBehaviour;
    
        #endregion // PRIVATE_MEMBER_VARIABLES

		//this code makes sure that the track on the text are igual to false
		//public GameObject spanishText;
		
		//public GameObject portugueseText;
				
				
				
				
		//Create a List of new Dropdown options
		List<string> m_DropdownSTOP = new List<string> {"portuguese", "spanish"};
		
		
		
		
		
		//List<TwoLangs> m_DropOptions = new List<TwoLangs>();
		//This is the Dropdown
		//m_DropOptions.
		
		public Dropdown m_Dropdown;
		
		
		//public Text selectedLanguage;
		public Text selectedLanguage;
			
	//selecting a languae
	public void Dropdown_IndexChanged(int index){
		
		selectedLanguage.text = m_DropOptions[index];
	}
        #region UNTIY_MONOBEHAVIOUR_METHODS
    
        void Start()
        {
            mTrackableBehaviour = GetComponent<TrackableBehaviour>();
            if (mTrackableBehaviour)
            {
                mTrackableBehaviour.RegisterTrackableEventHandler(this);
            }
			
			//this code makes sure that the track on the text are igual to false
			 
			PopulateList();
			 
			 //Fetch the Dropdown GameObject the script is attached to
			/*m_Dropdown = GetComponent<Dropdown>();
			//Clear the old options of the Dropdown menu
			m_Dropdown.ClearOptions();*/
			//Add the options created in the List above
			
			
		/*	if(m_DropOptions = 0){
				spanishText.gameObject.SetActive (false);
			} else{
				
				 
			 portugueseText.gameObject.SetActive (false);
			}*/
/*        }
		
		void PopulateList(){
			m_Dropdown.AddOptions(m_DropOptions);
		}

        #endregion // UNTIY_MONOBEHAVIOUR_METHODS



        #region PUBLIC_METHODS

        /// <summary>
        /// Implementation of the ITrackableEventHandler function called when the
        /// tracking state changes.
        /// </summary>
        public void OnTrackableStateChanged(
                                        TrackableBehaviour.Status previousStatus,
                                        TrackableBehaviour.Status newStatus)
        {
            if (newStatus == TrackableBehaviour.Status.DETECTED ||
                newStatus == TrackableBehaviour.Status.TRACKED ||
                newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
            {
                OnTrackingFound();
            }
            else
            {
                OnTrackingLost();
            }
        }

        #endregion // PUBLIC_METHODS



        #region PRIVATE_METHODS

	
        private void OnTrackingFound()
        {
			
			//if(portugueseText != languageSelected){
				// portugueseText.gameObject.SetActive (true);
			//}elseif(portugueseText != languageSelected){
		
			//	 spanishText.gameObject.SetActive (true);
			/*}else{
				Debug.Log("Language not Available");
			}*/
				//portugueseText = portugueseText.gameObject.SetActive (true);
				
				
   /*         if (portugueseText)
            {
                portugueseText.gameObject.SetActive (true);
				//spanishText.text = m_DropOptions;
            }
			else if(spanishText){
				spanishText.gameObject.SetActive (true);
				// portugueseText.text = m_DropOptions;
			}else{
				Debug.Log("Nothing here!");
			}
				 
				Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
				Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);

				// Enable rendering:
				foreach (Renderer component in rendererComponents)
				{
					component.enabled = true;
				}

				// Enable colliders:
				foreach (Collider component in colliderComponents)
				{
					component.enabled = true;
				}

				Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
			//}

		}
        private void OnTrackingLost()
        {
			spanishText.gameObject.SetActive (false);
			
			portugueseText.gameObject.SetActive (false);
			
            Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
            Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);

            // Disable rendering:
            foreach (Renderer component in rendererComponents)
            {
                component.enabled = false;
            }

            // Disable colliders:
            foreach (Collider component in colliderComponents)
            {
                component.enabled = false;
            }

            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
        }

        #endregion // PRIVATE_METHODS
    }
}
*/