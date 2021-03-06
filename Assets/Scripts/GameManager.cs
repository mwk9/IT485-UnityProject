﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour 
{
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }

    /*[SerializeField]
    private GameObject scorePrefab;
    public GameObject ScorePrefab
    {
        get
        {
            return scorePrefab;
        }
    }*/

    //[SerializeField]
    //private Text scoreText;
    private static int score = 0;
    public int Score
    {
        get
        {
            return score;
        }

        set
        {
            //scoreText.text = value.ToString();
            score = value;
        }
    }
    [SerializeField]
    private int scoreToWin;
    [SerializeField]
    private Text scoreText;
    [SerializeField]
    private Image scoreBar;
    [SerializeField]
    private GameObject nextSceneUI;
    //[SerializeField]
    //private string nextSceneName;

    //[SerializeField]
    //private Text livesText;
    [SerializeField]
    private static int lives = 7;
    public int Lives
    {
        get
        {
            return lives;
        }
        set
        {
            lives = value;
        }
    }

    private static int specialAmmo = 0;
    public int SpecialAmmo
    {
        get
        {
            return specialAmmo;
        }
        set
        {
            specialAmmo = value;
        }
    }
    [SerializeField]
    private Text ammoText;
    [SerializeField]
    private Image ammoBar;

    private static int currentWeapon = 0;
    public int CurrentWeapon
    {
        get
        {
            return currentWeapon;
        }
        set
        {
            currentWeapon = value;
        }
    }

    // Use this for initialization
    void Awake()
    {
        //livesText.text = "x" + lives.ToString();
        //if (score == 0)
        //{
        //    scoreText.text = score.ToString();
        //}
        score = 0;
        if (nextSceneUI != null)
            nextSceneUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //scoreText.text = score.ToString();
        //livesText.text = "x" + lives.ToString();
        if (score >= scoreToWin)
        {
            //SceneManager.LoadScene(nextSceneName);
            if (nextSceneUI != null)
                nextSceneUI.SetActive(true);
        }

        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
        if (scoreBar != null)
        {
            scoreBar.fillAmount = (float)score / (float)scoreToWin;
        }
        if (ammoText != null)
        {
            if (specialAmmo == 0)
                ammoText.text = "";
            else
                ammoText.text = "Ammo: " + specialAmmo.ToString();
        }
        if (ammoBar != null)
        {
            ammoBar.fillAmount = (float)specialAmmo / 10f;
        }

    }
}
