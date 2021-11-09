using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UIElements;

public class NetworkMananger : MonoBehaviourPunCallbacks
{
  

    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
     public override void OnConnectedToMaster()
     {
        Debug.Log("connect to Classe");
        PhotonNetwork.JoinOrCreateRoom("CLASSROOM",null ,TypedLobby.Default );
     }
    public override void OnJoinedRoom()
    {
        Debug.Log("Room joined");
        PhotonNetwork.Instantiate("Student",  new Vector3 ( 1.39f,0.60f, -3.73f),Quaternion.identity);
     }
    void Update()
    {
        
    }
}
