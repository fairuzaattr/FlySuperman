﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public static GameController instance;
    public GameObject gameOvertext;
    public bool gameOver = false;
    public float scrollSpeed = 5.0f;
    private int score = 0;
    public Text scoreText;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        gameOvertext.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if (gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            gameOvertext.SetActive(false);
           
        }

        
    }

    public void BirdDied()
    {
        gameOvertext.SetActive(true);
        gameOver = true;
       
    }

public void BirdScored()
{
        if (gameOver)
        	return;
        score++;
        scoreText.text = "Score: " + score.ToString();
}




}