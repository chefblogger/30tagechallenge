using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{


private int oldCoins;
private int newCoins;

//check wieviele coins in level gesammelt - fängt immer bei 0 bei level an
private int oldLevelCoins;
private int NewLevelCoins;

private void OnCollisionEnter(Collision collision)
     {
        if (collision.transform.tag == "Player")
        {
            
 

            oldCoins = PlayerPrefs.GetInt("CashPoints");
            newCoins = oldCoins + 1;

            

            oldLevelCoins = PlayerPrefs.GetInt("LevelCoins");
            NewLevelCoins = oldLevelCoins + 1;
            PlayerPrefs.SetInt("LevelCoins", NewLevelCoins );

            PlayerPrefs.SetInt("CashPoints", newCoins );
            gameObject.SetActive(false);
        }

    }
}
