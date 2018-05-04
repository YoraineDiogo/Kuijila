/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chat : MonoBehaviour {

	public List<string> chatHistory = new List<string>();
	
	private string currentMessage = string.Empty;
	
	private void OnGUI(){
		
	//	if (!NetworkMenu.Connected)
		//	return;
		
		GUILayout.BeginHorizontal(GUILayout.Width(250));
		currentMessage = GUILayout.TextField(currentMessage);
		if(GUILayout.Button("Send")){
			if(!string.IsNullOrEmpty(currentMessage.Trim()))
			{
				networkView.RPC("ChatMessage", RPCMode.AllBuffered, new object[] {currentMessage});
				currentMessage = string.Empty;
				
			}
		}
		GUILayout.EndHorizontal();
		
		foreach(string c in chatHistory)
			GUILayout.Label(c);
	}
	
	[RPC]
	public void ChatMessage(string message)
	{
		chatHistory.Add(message);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}*/
