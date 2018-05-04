/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Server : MonoBehaviour {

	//private bool serverStarted;

	private List<ServerClient> clients;
	private List<ServerClient> disconnectList;
	
	public int port = 6321;
	private TcpListener server;
	private bool serverStarted;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!serverStarted)
			return;
		
		foreach (ServerClient c in clients)
		{
			//is the client still connected
			if(!IsConnected(c.tcp))
			{
				c.tcp.Close();
				disconnectList.Add(c);
				continue;
			}
			
			//check for message from the client
			else{
				NetworkStream s = c.tcp.GetStream();
				if(s.DataAvailable){
					StreamReader reader = new StreamReader(s, true);
					string data = reader.ReadLine();
					
					if(data != null)
						OnIncomingData(c,data);
				}
			}
		}
		
		for(int i=0; i<disconnetList.Count - 1; i++){
			
			Broadcast(disconnectList[i].clientName + "has disconnected", clients);
			
			clients.Remove(disconnectList[i]);
			disconnectList.RemoveAt(i);
		}
			
	}

	private void StartListening(){
		
	}
	
	private bool IsConnected(TcpClient c){
		
	}
	
	private void AcceptTcpClient(IAsyncResult ar)
	{
		TcpListener listener = (TcpListener)ar.AsyncState;
		
		clients.Add(new ServerClient(listener.EndAcceptTcpClient(ar)));
		StartListening();
		
		//Send message to everyone, say someone has connected
		//Broadcast(clients[clients.Count-1].clientName + "has connected",clients);
		Broadcast("%NAME", new List<ServerClient>() { clients[clients.Count - 1]});
	}
	
	private void OnIncomingData(ServerClient c, string data)
	{
		if(data.Contains("%NAME"))
		{
			c.clientName = data.Split('|')[1];
			Broadcast(c.clientName + " has connected ");
			return;
		}
		
		Broadcast(c.clientName + " : " + data,clients);
		
		//Debug.Log(c.clientName + "has sent the following message : " + data);
	}
	
	private void Broadcast(string data, List<ServerClient>cl){
		
		foreach(ServerClient c in cl)
		{
			try{
				StreamWriter writer = new StreamWriter(c.tcp.GetStream());
				writer.WriteLine(data);
				writer.Flush();
			}
			catch(Exception e){
				Debug.Log("Write error :" + e.Message + "to client" + c.clientName);
			}
		}
	}
}

public class ServerClient
{
	public TcpClient tcp;
	public string clientName;
	
	public ServerClient(TcpClient clientSocket)
	{
		
	}
}*/
