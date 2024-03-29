﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] merchantTypes;
    private GameManager gameManagerScript;
    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = GameObject.Find("Game Manager").GetComponent<GameManager>();
        InvokeRepeating("SpawnMerchant", 4.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnMerchant()
    {
        //generates merchant from invoke repeating, rng if >6 then we spawn
        
        //try to generate merchant chnace
        int chance = Random.Range(0, 10);
        //generate merchant on left or right side
        int right = Random.Range(0, 1);
        //generate random type of merchant
        int merch_type = Random.Range(0, 10);
        if (merch_type == 9) {
            merch_type = 1;
        }
        else
        {
            merch_type = 0;
        }
        
        if (chance > 6 && gameManagerScript.isGameActive && gameManagerScript.isMovementActive )
        {
            Instantiate(merchantTypes[merch_type], new Vector3(355, 0, -20), merchantTypes[merch_type].transform.rotation);
        }

    }
}
