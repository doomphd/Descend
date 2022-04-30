// using UnityEngine;
// using System;

// public class ResponseKeyInputEventArgs : ExtendedEventArgs {
// 	public int id { get; set; }
// 	public float x { get; set; }
// 	public ResponseKeyInputEventArgs() {
// 		event_id = Constants.SMSG_KEY;
// 	}

// }

// public class ResponseKeyInput : NetworkResponse {

// 	public int id;
// 	public float x;

// 	public ResponseKeyInput() {
// 	}

// 	public override void parse() {
// 		id = DataReader.ReadInt(dataStream);
// 		x = DataReader.ReadFloat(dataStream);
// 	}

// 	public override ExtendedEventArgs process() {
// 		ResponseKeyInputEventArgs args = null;
// 		args = new ResponseKeyInputEventArgs();
// 		args.id = id;
// 		args.x = x;
// 		return args;
// 	}

// }