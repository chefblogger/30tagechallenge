using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startMenuGameData : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //wieviele leben hat der user?
        PlayerPrefs.SetInt("lifepoint", 3);

        //coins usw
        
        PlayerPrefs.SetInt("CashPoints", 0);

        PlayerPrefs.SetInt("AutoGang", 1);

        PlayerPrefs.SetFloat("HealthPoints", 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
