/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Net;
using System.Net.Sockets;
using System.IO;

public class chat : MonoBehaviour {

	private bool socketReady;
	private TcpCLient socket;
	private NetworkStream stream;
	private StreamWriter writer;
	private StreamReader reader;
	
	public void ConnectToServer()
	{
		//if already connected ignore this function
			if(socketReady)
				return;
			
		//Default host / port values
		string host = "127.0.0.1";
		int port = 6321;
		
		//Overwrite default host / port values, if there is something in those boxes
		string h;
		int p;
		h = GameObject.Find("HostInput").GetComponent<InputField>().text;
		if(h != "")
			host = h;
		
		int.TryParse(GameObject.Find("PortInput").GetComponent<InputField>().text, out p);
		if(p != 0)
			port = p;
		
		//create socket
		try{
			socket = new TcpCLient(host, port);
			stream = socket.GetStream();
			writer = new StreamWriter(stream);
			reader = new StreamReader(stream);
			socketReady = true;
		}
		catch(Exception e)
		{
			Debug.log("Socket error :" + e.Message);
		}
		
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private void Update () {
		if(socektReady)
		{
			if(stream.DataAvailable)
			{
				string data = reader.ReadLine();
				if(data != null)
					OnIncomingData(data);
			}
		}
	}
	
	private void OnIncomingData(string data)
	{
		if(data == "%NAME")
		{
			Send("%NAME" + clientName);
			return;
		}
		
		GameObject go = Instantiate(messagePrefab, chatContainer.transform) as GameObject;
		go.GetComponentInChildren<Text>().text = data;
		Debug.Log("Server :" + data);
	}
}
*/