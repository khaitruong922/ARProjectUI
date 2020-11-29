﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private PlayerReader playerReader;
    [SerializeField]
    private PlayerView[] playerViews;
    [SerializeField]
    private KeyCode updateKey = KeyCode.Space;
    // private IEnumerator Start()
    // {
    //     while (true)
    //     {
    //         UpdateAllViews();
    //         yield return new WaitForSeconds(2f);
    //     }
    // }
    private void Update()
    {
        if (Input.GetKeyDown(updateKey))
        {
            UpdateAllViews();
        }
    }
    private void UpdateAllViews()
    {
        Player[] players = playerReader.GetAll();
        for (int i = 0; i < playerViews.Length; i++)
        {
            Player player = players[i];
            foreach (var card in player.cards)
            {
                print(card.x);
            }
            playerViews[i].UpdateView(player);

        }
    }
}