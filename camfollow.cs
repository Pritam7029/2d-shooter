using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class camfollow : MonoBehaviour
{
    PhotonView view;
    private GameObject cam;
    private GameObject _player;
    //private float speed = 10f;
    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("cam");
        _player = GameObject.FindGameObjectWithTag("Player");
        view = _player.GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {
            gameObject.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y, cam.transform.position.z);
            gameObject.transform.LookAt(_player.gameObject.transform.position);
        }

       
    }
}
