using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muenzen : MonoBehaviour
{


private void OnCollisionEnter(Collision collision)
     {
        if (collision.transform.tag == "Player")
        {
            
            //objekt zerstören
            //Destroy(collision.gameObject);
            //collision.gameObject.SetActive(false);
            
            
            Destroy(gameObject);
            
            //Debug.Log("COIND");

            //punkt geben

            //scoreboard.score += 1;

            
            //startData.score += 1;

            //alter coin zwischenstand laden
            //oldCoins = PlayerPrefs.GetInt("TempCashPoints");
            //newCoins = oldCoins + 1;
            //PlayerPrefs.SetInt("TempCashPoints", newCoins );
            //gameObject.SetActive(false);
 

        }

    }
    
}
