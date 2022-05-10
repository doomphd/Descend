using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using Photon.Realtime;
public class LaunchManager : MonoBehaviourPunCallbacks
{

    public GameObject EnterGamePanel;
    public GameObject ConnectionStatusPanel;
    public GameObject LobbyPanel;


 private void Awake() {
        PhotonNetwork.AutomaticallySyncScene = true;


    }

    // Start is called before the first frame update
    void Start()
    {
        EnterGamePanel.SetActive(true);
        ConnectionStatusPanel.SetActive(false);
        LobbyPanel.SetActive(false);

    }


     public void connectToPhotonServer(){
        if(!PhotonNetwork.IsConnected){
            PhotonNetwork.ConnectUsingSettings();
             ConnectionStatusPanel.SetActive(true);
             EnterGamePanel.SetActive(false);

        }

           
     }
    
    
  




    
    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnJoinRandomFailed (short returnCode, string message){
        base.OnJoinRandomFailed(returnCode, message);
        Debug.Log(message);
        CreateAndJoinRoom();

    }   

    public void CreateAndJoinRoom(){
        string RandomRoomName = "Room" + Random.Range(0,1000);
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.IsOpen = true;
        roomOptions.IsVisible = true;
        roomOptions.MaxPlayers = 2;
        PhotonNetwork.CreateRoom(RandomRoomName, roomOptions);

    }

public override void OnJoinedRoom(){
    Debug.Log(PhotonNetwork.NickName + " joined to " + PhotonNetwork.CurrentRoom.Name);
    PhotonNetwork.LoadLevel("Level_1");

}

public override void OnPlayerEnteredRoom(Photon.Realtime.Player newPlayer){
    Debug.Log(newPlayer.NickName + " joined to " + PhotonNetwork.CurrentRoom.Name + " " + PhotonNetwork.CurrentRoom.PlayerCount);
}

    public override void OnConnectedToMaster() {
        Debug.Log(PhotonNetwork.NickName + " Connected to Server, There is ? player in the room.");
        LobbyPanel.SetActive(true);
        ConnectionStatusPanel.SetActive(false);
    }

public void JoinRandomRoom(){
    PhotonNetwork.JoinRandomRoom();

}



}



