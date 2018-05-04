/*==============================================================================
Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

/*
	Script modified by 
	  Yoraine Diogo
	   April 2018
*/

using System.Collections.Generic;
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
		
		
		//creating a text gameObject		
		public Text selectedLanguage;
		
		
		/*public Text application;
		public Text app;*/
		
		//COLORS **************************************************************************
		public Text red;
		
		public Text kuijila;
		public Text developed;
		public Text YorMby;
		public Text Yoraine;
		public Text Diogo;
		
		
		
		//ANIMALS *************************************************************************
		public Text turtle;
		
		
		public Text I;
		public Text am;
		
		// WHERE THERE IS LIFE, THERE IS HOPE
		public Text wher;
		public Text ther;
		public Text iss;
		public Text life;
		public Text there;
		public Text isss;
		public Text hope;
		
		//"EDUCATION IS THE MOST POWERFUL WEAPON YOU CAN USE TO CHANGE THE WORLD" - Nelson Mandela
		public Text education;
		public Text educationIS;
		public Text educationTHE;
		public Text educationMOST;
		public Text educationPOWERFUL;
		public Text educationWEAPON;
		public Text educationYOU;
		public Text educationCAN;
		public Text educationUSE;
		public Text educationTO;
		public Text educationChange;
		public Text educationTHE2;
		public Text educationWORLD;
		
		//THE LIMITS OF MY LANGUAGE ARE THE LIMITS OF MY WORLD - Ludwig Wittgenstein
		public Text ludwigTHE;
		public Text ludwigLIMITS;
		public Text ludwigOF;
		public Text ludwigMY;
		public Text ludwigLANGUAGE;
		public Text ludwigARE;
		public Text ludwigTHE2;
		//public Text ludwigLIMITS;
		public Text ludwigOF2;
		public Text ludwigMY2;
		public Text ludwigWORLD ;
		
		//Create a List of new Dropdown options ***********************************************************
		List<string> m_DropOptions = new List<string> {" ", "Portuguese", "Spanish", "Kimbundu"};
			
		//m_DropOptions.
		public Dropdown m_Dropdown;
		
		
		List<string> m_DropStop = new List<string> {"Select A Language", "Parar", "Detener", "Coming Soon"};
		List<string> m_DropRed = new List<string> {"Select A Language","Vermelho", "rojo", " Coming Soon"};
		List<string> m_DropTurtle = new List<string> {"Select A Language","Tartaruga", "Tortuga", "Coming Soon"};
		//List<string> m_DropYou = new List<string> {"Select A Language","Tu, Você", "Tú, Ustedes", "Etu"};
		//List<string> m_DropGood = new List<string> {"Select A Language","Bom", "Buenos", " "};
		//List<string> m_DropMorning = new List<string> {"Select A Language","Dia", "Dias", "Wasekele "};
		List<string> m_DropI = new List<string> {"Select A Language","Eu", "Yo", "Eme"};
		List<string> m_DropAm = new List<string> {"Select A Language","Sou", "Soy", " Coming Soon"};
		
		//where there is life, there is hope SENTENCE
		List<string> m_DropWhere = new List<string> {"	"				,"Onde"		, "Dónde"	 , " "};
		List<string> m_DropThere = new List<string> {""					,"há"		, "hay"	 	 , " "};
		List<string> m_DropIs = new List<string> {""					," "		, " "		 , " "};
		List<string> m_DropLife = new List<string> {"Select A Language"	,"vida,"	, "vida,"	 , "Coming Soon "};
		List<string> m_DropThere2 = new List<string> {""				,"há"		, "hay"		 , " "};
		List<string> m_DropIss = new List<string> {""					," "		, " "		 , " "};
		List<string> m_DropHope = new List<string> {""					,"Esperança", "esperanza", " "};
		
		//EDUCATION IS THE MOST POWERFUL TOOL YOU CAN USE TO CHANGE THE WORLD - NELSON MANDELA
		List<string> m_DropEducation = new List<string> {"                 "         ,"Educação"    ,  "La"           , " "};
		List<string> m_DropEducationIS = new List<string> {"                 "       ,   "é"        ,  "educación"           , " "};
		List<string> m_DropEducationTHE = new List<string> {"				  "      ,   "a"        ,  "es"    , " "};
		List<string> m_DropEducationMOST = new List<string> {"				   "     ,"mais"	    ,  "herramienta"           , " "};
		List<string> m_DropEducationPOWERFUL = new List<string> {"				   " , "poderosa"   ,  "más"  	 	  , " "};
		List<string> m_DropEducationWEAPON = new List<string> {"				 "   ,"ferramenta"  ,  "la"  , " "};
		List<string> m_DropEducationYOU = new List<string> {"				  "      ,"que tu"      ,  "poderosa"     , " "};
		List<string> m_DropEducationCAN = new List<string> {"Select A Language"      ,"podes"       ,  "que"          , "COMING SOON "};
		List<string> m_DropEducationUSE = new List<string> {"				  "      ,"usar"        ,  "podemos"      , " "};
		List<string> m_DropEducationTO = new List<string> {"				 "       ,"para"        ,  "usar"         , " "};
		List<string> m_DropEducationChange = new List<string> {"			     "   ,"mudar     "  ,  "para"         , " "};
		List<string> m_DropEducationTHE2 = new List<string> {"				   "     ,"o"           ,  "cambiar"      , " "};
		List<string> m_DropEducationWORLD = new List<string> {"					"    ,"Mundo"       ,  "el mundo"      , " "};
		
		//THE LIMITS OF MY LANGUAGE ARE THE LIMITS OF MY WORLD
		List<string> m_DropLudwigTHE = new List<string> {"					"        ,   "Os"    ,  "Los"        , " "};
		List<string> m_DropLudwigLIMITS = new List<string> {"				   "     ,"limites"  ,  "límites   " , " "};
		List<string> m_DropLudwigOF = new List<string> {"				   "         ,   "da"    ,  "de"         , " "};
		List<string> m_DropLudwigMY = new List<string> {"				   "         ,"minha"    ,  "mi"         , " "};
		List<string> m_DropLudwigLANGUAGE = new List<string> {"   				 "   ,"língua"   ,  "lenguaje"   , " "};
		List<string> m_DropLudwigARE = new List<string> {"Select A Language"         ,"são"      ,  "son"        , "COMING SOON "};
		List<string> m_DropLudwigTHE2 = new List<string> {"					"        ,"os"       ,  "los"        , " "};
		//List<string> m_DropEducationLIMITS= new List<string> {"Select A Language"  ,"limites"  ,  "límites"    , " "};
		List<string> m_DropLudwigOF2 = new List<string> {"				   "         ,"do    "   ,  "de"         , " "};
		List<string> m_DropLudwigMY2 = new List<string> {"	   "         ,"meu"      ,  "mi"         , " "};
		List<string> m_DropLudwigWORLD = new List<string> {"				  "      ,"Mundo"    ,  "mundo"      , " "};
		
		List<string> m_DropYorMKuijila= new List<string> {" Kuijila "		, "Kuijila "	 , "Kuijila" 		, "Kuijila"};
		List<string> m_DropYorMDeveloped= new List<string> {" Developed "	, "Desenvolvida" , "Desarollada" 	, "Desenvolvida"};
		List<string> m_DropYorMBy = new List<string> {"	by "				, "por"          , "por "			, "by"};
		List<string> m_DropYorMYoraine = new List<string> {"Yoraine"		, "Yoraine"		 ,	"Yoraine"		, "Yoraine"};
		List<string> m_DropYorMDiogo= new List<string> {"Diogo"				, "Diogo"		 , "Diogo"			, "Diogo"};
		
		
		
		
		//selecting a language -- this code below is what creates the gameObject************************************************************
		public void Dropdown_IndexChanged(int index){
			//this shows that the public text is equal to the translated words.
			selectedLanguage.text = m_DropStop[index];
			red.text = m_DropRed[index];
			turtle.text = m_DropTurtle[index];
			
			I.text = m_DropI[index];
			am.text = m_DropAm[index];
			
			
			
//________________________________________________SENTENCES_______________________________________________________
			
			//WHILE THERE IS LIFE, THERE IS HOPE - 
			wher.text = m_DropWhere[index];
			ther.text = m_DropThere [index];
			iss.text = m_DropIs[index];
			life.text = m_DropLife[index];
			there.text = m_DropThere2[index]; 
			isss.text = m_DropIss[index];
			hope.text = m_DropHope[index]; 
			
			
			education.text = m_DropEducation[index]; 
			educationIS.text = m_DropEducationIS[index]; 
			educationTHE.text = m_DropEducationTHE[index]; 
			educationMOST.text = m_DropEducationMOST[index]; 
			educationPOWERFUL.text = m_DropEducationPOWERFUL[index]; 
			educationWEAPON.text = m_DropEducationWEAPON[index]; 
			educationYOU.text = m_DropEducationYOU[index]; 
			educationCAN.text =	m_DropEducationCAN[index]; 
			educationUSE.text = m_DropEducationUSE[index]; 
			educationTO.text = m_DropEducationTO[index]; 
			educationChange.text = m_DropEducationChange[index]; 
			educationTHE2.text = m_DropEducationTHE2[index]; 
			educationWORLD.text = m_DropEducationWORLD[index]; 
		
			//THE LIMITS OF MY LANGUAGE ARE THE LIMITS OF MY WORLD
			ludwigTHE.text = m_DropLudwigTHE[index]; 
			ludwigLIMITS.text = m_DropLudwigLIMITS[index]; 
			ludwigOF.text = m_DropLudwigOF[index]; 
			ludwigMY.text = m_DropLudwigMY[index]; 
			ludwigLANGUAGE.text = m_DropLudwigLANGUAGE[index]; 
			ludwigARE.text = m_DropLudwigARE[index]; 
			ludwigTHE2.text = m_DropLudwigTHE2[index]; 
			//ludwigLIMITS.text = m_DropLudwigLIMITS[index]; 
			ludwigOF2.text = m_DropLudwigOF2[index]; 
			ludwigMY2.text = m_DropLudwigMY2[index]; 
			ludwigWORLD.text = m_DropLudwigWORLD[index]; 
			
			
			developed.text = m_DropYorMDeveloped[index];
			YorMby.text = m_DropYorMBy[index]; 
			Yoraine.text = m_DropYorMYoraine[index]; 
			Diogo.text = m_DropYorMDiogo[index]; 
			kuijila.text = m_DropYorMKuijila[index]; 
		}
        #region UNTIY_MONOBEHAVIOUR_METHODS
    
	
	
		//Here is where the AR functionality starts - without this the text will appear on screen
        void Start()
        {
            mTrackableBehaviour = GetComponent<TrackableBehaviour>();
            if (mTrackableBehaviour)
            {
                mTrackableBehaviour.RegisterTrackableEventHandler(this);
            }
			
			/*this code makes sure that the track on the text are igual to false, which means it won't come up on the screen before
				a words are viewed from the camera.
			*/
			selectedLanguage.gameObject.SetActive(false);
			red.gameObject.SetActive(false);
			turtle.gameObject.SetActive(false);
			I.gameObject.SetActive(false);
			am.gameObject.SetActive(false);
			
			// Nelson Mandela
			wher.gameObject.SetActive(false);
			ther.gameObject.SetActive(false);
			iss.gameObject.SetActive(false);
			life.gameObject.SetActive(false);
			there.gameObject.SetActive(false);
			isss.gameObject.SetActive(false);
			hope.gameObject.SetActive(false);
			
			
			// 
			education.gameObject.SetActive(false);
			educationIS.gameObject.SetActive(false);
			educationTHE.gameObject.SetActive(false);
			educationMOST.gameObject.SetActive(false); 
			educationPOWERFUL.gameObject.SetActive(false);
			educationWEAPON.gameObject.SetActive(false);
			educationYOU.gameObject.SetActive(false);
			educationCAN.gameObject.SetActive(false);
			educationUSE.gameObject.SetActive(false);
			educationTO.gameObject.SetActive(false);
			educationChange.gameObject.SetActive(false);
			educationTHE2.gameObject.SetActive(false);
			educationWORLD.gameObject.SetActive(false);
			
			//THE LIMITS OF MY LANGUAGE ARE THE LIMITS OF MY WORLD - LUDWIG WITTGENSTEIN
			ludwigTHE.gameObject.SetActive(false);
			ludwigLIMITS.gameObject.SetActive(false);
			ludwigOF.gameObject.SetActive(false);
			ludwigMY.gameObject.SetActive(false);
			ludwigLANGUAGE.gameObject.SetActive(false);
			ludwigARE.gameObject.SetActive(false);
			ludwigTHE2.gameObject.SetActive(false);
			//public Text ludwigLIMITS;
			ludwigOF2.gameObject.SetActive(false);
			ludwigMY2.gameObject.SetActive(false);
			ludwigWORLD.gameObject.SetActive(false);
			
			developed.gameObject.SetActive(false);
			YorMby.gameObject.SetActive(false);
			Yoraine.gameObject.SetActive(false);
			Diogo.gameObject.SetActive(false);
			kuijila.gameObject.SetActive(false);

			PopulateList();
        }
		
		void PopulateList(){
			
			 //Fetch the Dropdown GameObject the script is attached to
			m_Dropdown = GetComponent<Dropdown>();
			//Clear the old options of the Dropdown menu
		//	m_Dropdown.ClearOptions();
			//Add the options created in the List above
	//		m_Dropdown.AddOptions(m_DropOptions);
			//m_Dropdown.AddOptions(m_DropStop);
		}

        #endregion // UNTIY_MONOBEHAVIOUR_METHODS


	/*	void update (){
			
			switch(m_Dropdown.OnValueChanged)
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
		
        #region PUBLIC_METHODS

		
		//this shows on the console when a word is tracked therefore found and seen on the screen by camera app
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

	
	
	
		/*this code makes sure that the text is igual to true, which means the words or sentences will come up on the screen
				from the it is recognised (onTrackingFound) by the camera app..
		*/
        private void OnTrackingFound()
        {	
							
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

				//	if(selectedLanguage.enabled = true)	{
				selectedLanguage.gameObject.SetActive(true);
			//}else if(red.enabled = true){
				
				red.gameObject.SetActive(true);
				//}
				turtle.gameObject.SetActive(true);
				
				//you.gameObject.SetActive (true);
				
				
				//nelson mandela
				I.gameObject.SetActive(true);
				am.gameObject.SetActive(true);
				wher.gameObject.SetActive(true);
				ther.gameObject.SetActive(true);
				iss.gameObject.SetActive(true);
				life.gameObject.SetActive(true);
				there.gameObject.SetActive(true);
				isss.gameObject.SetActive(true);
				hope.gameObject.SetActive(true);
				
				
				//
				education.gameObject.SetActive(true);
				educationIS.gameObject.SetActive(true);
				educationTHE.gameObject.SetActive(true);
				educationMOST.gameObject.SetActive(true); 
				educationPOWERFUL.gameObject.SetActive(true);
				educationWEAPON.gameObject.SetActive(true);
				educationYOU.gameObject.SetActive(true);
				educationCAN.gameObject.SetActive(true);
				educationUSE.gameObject.SetActive(true);
				educationTO.gameObject.SetActive(true);
				educationChange.gameObject.SetActive(true);
				educationTHE2.gameObject.SetActive(true);
				educationWORLD.gameObject.SetActive(true);
				
				//THE LIMITS OF MY LANGUAGE ARE THE LIMITS OF MY WORLD - LUDWIG WITTGENSTEIN
				ludwigTHE.gameObject.SetActive(true);
				ludwigLIMITS.gameObject.SetActive(true);
				ludwigOF.gameObject.SetActive(true);
				ludwigMY.gameObject.SetActive(true);
				ludwigLANGUAGE.gameObject.SetActive(true);
				ludwigARE.gameObject.SetActive(true);
				ludwigTHE2.gameObject.SetActive(true);
				//public Text ludwigLIMITS;
				ludwigOF2.gameObject.SetActive(true);
				ludwigMY2.gameObject.SetActive(true);
				ludwigWORLD.gameObject.SetActive(true);
				
				developed.gameObject.SetActive(true);
				//public Text ludwigLIMITS;
				YorMby.gameObject.SetActive(true);
				Yoraine.gameObject.SetActive(true);
				Diogo.gameObject.SetActive(true);
				kuijila.gameObject.SetActive(true);
				
				Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
			

		}
		
		
		
		/*this code makes sure that the text is igual to false, which means the words or sentences wiil disappear from the screen as soon
				as there are no words to be recognised (onTrackingLost) by the camera app..
		*/ 
        private void OnTrackingLost()
        {
			
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

			selectedLanguage.gameObject.SetActive(false);
			red.gameObject.SetActive(false);
			turtle.gameObject.SetActive(false);
			//you.gameObject.SetActive(false);
			I.gameObject.SetActive(false);
			am.gameObject.SetActive(false);
			
			//
			wher.gameObject.SetActive(false);
			ther.gameObject.SetActive(false);
			iss.gameObject.SetActive(false);
			life.gameObject.SetActive(false);
			there.gameObject.SetActive(false);
			isss.gameObject.SetActive(false);
			hope.gameObject.SetActive(false);
			
			
			//NELSON MANDELA
			education.gameObject.SetActive(false);
			educationIS.gameObject.SetActive(false);
			educationTHE.gameObject.SetActive(false);
			educationMOST.gameObject.SetActive(false); 
			educationPOWERFUL.gameObject.SetActive(false);
			educationWEAPON.gameObject.SetActive(false);
			educationYOU.gameObject.SetActive(false);
			educationCAN.gameObject.SetActive(false);
			educationUSE.gameObject.SetActive(false);
			educationTO.gameObject.SetActive(false);
			educationChange.gameObject.SetActive(false);
			educationTHE2.gameObject.SetActive(false);
			educationWORLD.gameObject.SetActive(false);
			
			
			//THE LIMITS OF MY LANGUAGE ARE THE LIMITS OF MY WORLD - LUDWIG WITTGENSTEIN
			ludwigTHE.gameObject.SetActive(false);
			ludwigLIMITS.gameObject.SetActive(false);
			ludwigOF.gameObject.SetActive(false);
			ludwigMY.gameObject.SetActive(false);
			ludwigLANGUAGE.gameObject.SetActive(false);
			ludwigARE.gameObject.SetActive(false);
			ludwigTHE2.gameObject.SetActive(false);
			//public Text ludwigLIMITS;
			ludwigOF2.gameObject.SetActive(false);
			ludwigMY2.gameObject.SetActive(false);
			ludwigWORLD.gameObject.SetActive(false);
			
			
			developed.gameObject.SetActive(false);
			YorMby.gameObject.SetActive(false);
			Yoraine.gameObject.SetActive(false);
			Diogo.gameObject.SetActive(false);
			kuijila.gameObject.SetActive(false);
			
            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
        }

        #endregion // PRIVATE_METHODS
    }
}
