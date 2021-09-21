using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_portal : MonoBehaviour
{
    public int CoinInLevel = 10;

    public int LevelCoins = 0;

   public GameObject portalToActivate;

    void Start(){
        //gameObject.SetActive(false);
        //PortalParticle = GameObject.Find("PortalParticle");
    }

    
    // Update is called once per frame
    void Update()
    {
       LevelCoins = PlayerPrefs.GetInt("LevelCoins");

       if (CoinInLevel == LevelCoins)
        {
            portalToActivate.SetActive(true);
        }

    }
}
