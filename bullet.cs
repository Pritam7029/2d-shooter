using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class bullet : MonoBehaviour
{
    public float firespeed = 30f;
    private Rigidbody2D rb;
    public GameObject sounds;




    void Start()
    {
        Vector3 mouseposition = Input.mousePosition;
        mouseposition = Camera.main.ScreenToWorldPoint(mouseposition);

        Vector2 direction = new Vector2(
        mouseposition.x - transform.position.x,
        mouseposition.y - transform.position.y
       );
        
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = direction.normalized * firespeed;
       // sounds1 = Random.value.
       
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "enemy")
        {
            Instantiate(sounds, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject, 2f);
        }
                
    }






}
