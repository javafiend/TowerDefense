﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public static bool gameEnded;
    public GameObject gameOverUI;

    void Start()
    {
        gameEnded = false;

    }
	// Update is called once per frame
	void Update () {

        if (gameEnded)
            return;

		if(PlayerStats.Hp <= 0)
        {
            EndGame();
        }
	}

    void EndGame()
    {
        gameEnded = true;
        gameOverUI.SetActive(true);
    }
}
