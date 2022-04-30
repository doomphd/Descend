// using System;
// using UnityEngine;

// public class RequestKeyInput : NetworkRequest 
// {
// 	public RequestKeyInput() 
// 	{
// 		request_id = Constants.CMSG_KEY;
// 	}
	
// 	public void send(InputManager.Keys pressedKey, int id) {
// 	    packet = new GamePacket(request_id);
//         packet.addInt32(id);
// 		packet.addInt32((int) pressedKey);
// 	}
// }