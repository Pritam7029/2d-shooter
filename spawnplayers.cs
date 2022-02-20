using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class spawnplayers : MonoBehaviour
{
    public GameObject playerprefabs;
   // public Transform spawnpoint1;
    public Vector2 spawnpoint2;



    private void Start()
    {
        PhotonNetwork.Instantiate(playerprefabs.name, spawnpoint2, Quaternion.identity);
    }
}
