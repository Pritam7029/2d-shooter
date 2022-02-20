using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class createandjoinrooms : MonoBehaviourPunCallbacks
{
    public InputField createinput;
    public InputField joininput;

    public void Createroom()
    {
        PhotonNetwork.CreateRoom(createinput.text);
    }
    public void Joinroom()
    {
        PhotonNetwork.JoinRoom(joininput.text);
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
