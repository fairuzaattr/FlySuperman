using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Column : MonoBehaviour
{

    public Text scoreText;          
    private int score = 0;
    
   
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Bird>() != null)
        {
            GameController.instance.BirdScored();
        }
    }

    
}
