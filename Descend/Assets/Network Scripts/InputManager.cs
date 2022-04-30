// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class InputManager : MonoBehaviour
// {   
//     private GameObject mainObject;
//     private MessageQueue msgQueue;
//     private ConnectionManager cManager; 
//     private GameManager gameManager;
//     public enum Keys{
//         None,
//         up,
//         down,
//         left,
//         right
//     }

//     public Keys pressKey;

//     void Awake(){
//         mainObject = GameObject.Find("MainObject");        
//         cManager = mainObject.GetComponent<ConnectionManager>();
//         msgQueue = mainObject.GetComponent<MessageQueue>();
//         msgQueue.AddCallback(Constants.SMSG_KEY, ResponseKeyInput);
//     }
//     void Start()
//     {
//         pressKey = Keys.None;
//         gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
//     }

//     // Update is called once per frame
//     void Update()
//     {   
//         // checkInput();
//     }

//     private void checkInput(){
//         if(Input.GetKeyDown(KeyCode.UpArrow)){
//             pressKey = Keys.up;
//         }   else if (Input.GetKeyUp(KeyCode.UpArrow)){
//             pressKey = Keys.None;
//         }
//         if(Input.GetKeyDown(KeyCode.DownArrow)){
//             pressKey = Keys.down;
//         }   else if (Input.GetKeyUp(KeyCode.DownArrow)){
//             pressKey = Keys.None;
//         }
//         if(Input.GetKeyDown(KeyCode.LeftArrow)){
//             pressKey = Keys.left;
//         }   else if (Input.GetKeyUp(KeyCode.LeftArrow)){
//             pressKey = Keys.None;
//         }
//         if(Input.GetKeyDown(KeyCode.RightArrow)){
//             pressKey = Keys.right;
//         }   else if (Input.GetKeyUp(KeyCode.RightArrow)){
//             pressKey = Keys.None;
//         }
//         // cManager.send(requestKeyInput(DBManager.id, pressKey));
//     }

//     public RequestKeyInput requestKeyInput(int id, Keys key) {
// 		RequestKeyInput request = new RequestKeyInput();
// 		request.send(key, id);
// 		return request;
// 	}

//     public void ResponseKeyInput(ExtendedEventArgs eventArgs) {
// 		ResponseKeyInputEventArgs args = eventArgs as ResponseKeyInputEventArgs;
// 		if(!GameManager.instance.playerList.ContainsKey(args.id)){
//             return;
//         }
//         GameManager.instance.playerList[args.id].transform.position = new Vector2(args.x,0);
//     }   
// }