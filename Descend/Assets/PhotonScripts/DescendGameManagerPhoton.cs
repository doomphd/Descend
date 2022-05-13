using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
public class DescendGameManagerPhoton : MonoBehaviourPunCallbacks
{

    [SerializeField]
    GameObject playerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        if(PhotonNetwork.IsConnected){
            if(playerPrefab != null){
                int RandomPoint1 = Random.Range(-40,-20);
                int RandomPoint2 = Random.Range(-20,0);

                    PhotonNetwork.Instantiate(playerPrefab.name, new Vector2(RandomPoint1,RandomPoint2),Quaternion.identity);

            }



        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

public override void OnJoinedRoom(){
    Debug.Log(PhotonNetwork.NickName + " joined to " + PhotonNetwork.CurrentRoom.Name + " Player Count in the Room: " + PhotonNetwork.CurrentRoom.PlayerCount);

}

public override void OnPlayerEnteredRoom(Photon.Realtime.Player newPlayer){
   
     Debug.Log(newPlayer.NickName + " joined to " + PhotonNetwork.CurrentRoom.Name + " Player Count in the Room: " + PhotonNetwork.CurrentRoom.PlayerCount);

}


}
