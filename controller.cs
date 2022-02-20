using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class controller : MonoBehaviour
{
    PhotonView view;
    //Variables
    public float upspeed;
    public float sidespeed;
    public GameObject bullet;
    public float firespeed;
    public float health = 100f;
    //References
    private Rigidbody2D rb;
    public float varspeed;
    private float horspeed;
    private GameObject playr;
    public Transform gunpos;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playr = GameObject.FindGameObjectWithTag("Player");
        view = GetComponent<PhotonView>();
    }
    void Update()
    {
        varspeed = Input.GetAxis("Vertical");
        horspeed = Input.GetAxis("Horizontal");
        if (view.IsMine)
        {
            Movement();
        }


        Lookat();
        Damage();
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Application Quit");
        }
       

    }
    
    public void Movement()
    {
        if (varspeed != 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, 5 * upspeed * varspeed);
        }
        if (horspeed != 0)
        {
            rb.velocity = new Vector2(5 * sidespeed * horspeed, rb.velocity.y);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
        
    }
    public void Lookat()
    {

        Vector3 mouseposition = Input.mousePosition;
        mouseposition = Camera.main.ScreenToWorldPoint(mouseposition);

            Vector2   direction = new Vector2(
            mouseposition.x - transform.position.x,
            mouseposition.y - transform.position.y
           );
        transform.right = direction;
     
    }
    public void Damage()
    {
        for (int i = 0; i <health; i++)
        {
            health = (health - 10f);
        }
    }
    private void Shoot()
    {
      Instantiate(bullet, gunpos.transform.position, Quaternion.identity);
    }
    
}
