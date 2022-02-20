using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyrandom : MonoBehaviour
{
    private Rigidbody2D rbr;
    private GameObject playr;
    public GameObject particlesys;
   
    private void Start()
    {
       playr = GameObject.FindGameObjectWithTag("Player");
     }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "bullet")
        { 
           Instantiate(particlesys,transform.position,Quaternion.identity);
           Destroy(gameObject);
           Debug.Log("enemy destroy itself");
               
        }
    }
}
