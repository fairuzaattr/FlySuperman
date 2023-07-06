using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    public float upForce;
    private bool isDead = false;
    private Rigidbody2D rb2d;
    private Animator anim;  
    float score;    
 

	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        
      
        
	}
	
	// Update is called once per frame
	void Update () {

        if (isDead == false)
        {
            if (Input.GetMouseButtonDown(0)) 
            {

                rb2d.velocity = Vector2.up*upForce;
                rb2d.AddForce(new Vector2(0, upForce));
                anim.SetTrigger("Flap");
                
            }
        }

	}


     void OnCollisionEnter2D(Collision2D other)
    {
        GameController.instance.BirdDied(); 
        isDead = true;
        anim.SetTrigger("Dead");
       
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Bird>() != null)
        {
            GameController.instance.BirdScored();
        }
    }
}
