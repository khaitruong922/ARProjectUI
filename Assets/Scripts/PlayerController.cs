﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerReader playerReader;
    [SerializeField]
    private PlayerView[] playerViews;
    [SerializeField]
    private KeyCode updateKey = KeyCode.Space;
    private void Awake()
    {
        playerReader = GetComponent<PlayerReader>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(updateKey))
        {
            Player[] players = playerReader.GetAll();
            for (int i = 0; i < playerViews.Length; i++)
            {
                playerViews[i].UpdateView(players[i]);
            }
        }
    }
}
