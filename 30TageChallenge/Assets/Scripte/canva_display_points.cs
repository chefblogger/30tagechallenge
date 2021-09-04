using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canva_display_points : MonoBehaviour
{

    private int oldCoins;
    
    public Text Cash;

    // Update is called once per frame
    void Update()
    {
        
         oldCoins = PlayerPrefs.GetInt("CashPoints");
         

    }
}
