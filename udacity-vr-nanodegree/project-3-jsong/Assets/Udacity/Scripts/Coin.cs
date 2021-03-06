﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    public GameObject CoinPoofPrefab;
    public AudioSource soundSource;

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy

        // Play sound when it collected
        soundSource.Play();

        // Animation
        // Make means to collect this item
        Debug.Log("Collected a coin!");

        Destroy(gameObject);


    }

}
