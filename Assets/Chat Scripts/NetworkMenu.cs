/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkMenu : MonoBehaviour {

	public string connectionIP = "127.0.0.1";
	public int portNumber =           8632;
	
	//private bool Connected = false;
	private static bool Connected {get; private set; }
	
	private void OnConnectedToServer()
	{
		//A client has just Connected
		Connected = true;

	}
	
	private void OnServerInitialized()
	{
		Connected = true;
	}
	
	private void OnDisconnectedFromServer()
	{
		Connected = false;
	}
	
	private void OnGUI(){
		if(!Connected)
		{
			connectionIP = GUILayout.TextField(connectionIP);
			int.TryParse(GUILayout.TextField(portNumber.ToString()), out portNumber);
			
			if(GUILayout.Button("Connect"))
				Network.Connect(connectionIP, portNumber);
			
			if (GUILayout.Button("Host"))
				Network.InitializeServer(4, portNumber, true);
		}
		else
			GUILayout.Label("Connections: " + Network.connections.Length.ToString());
		
	}
			
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}*/
