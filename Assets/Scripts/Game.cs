using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public ScoreCounter ScoreCounter;
    public Readouts Readouts;
    public Corgi Corgi;
    //public Readouts Readouts;
    public static Game Instance;

    public float scrollSpeed = -1.5f;
    public bool gameOver = false;
    public int score = 0;

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        Reset();
    }

    private void FixedUpdate()
    {
        UpdateScore();
        CheckForGameOver();
    }

    public void CheckForGameOver()
    {
        if (Corgi.isInPlay == false)
            LoseGame();
    }

    public void LoseCorgi()
    {
        Corgi.CreateDeathEffect();
        //Sounds.Instance.PlayLoseBall();
        DisableGameplay();
        //CheckForGameOver();
    }

    public void DisableGameplay()
    {
        Corgi.Disable();
    }

    public void OutOfPlay()
    {
        Corgi.isInPlay = false;
    }


    private void WinGame()
    {
        Readouts.ShowWinResult();
    }

    private void LoseGame()
    {
        Readouts.ShowLoseResult();
        //Sounds.Instance.PlayGameOver();
    }

    private void Reset()
    {
        //reset score and game 
    }

    private void UpdateScore()
    {
        float score = ScoreCounter.GetCurrentScore();
        Readouts.ShowScore(score);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }


    //public void Score()
    //{
    //    if (gameOver)
    //    {
    //        return;
    //    }

    //    score++;
    //}

    //public void Die()
    //{
        
    //}

}
