using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{

private int oldCoins;
private int newCoins;

private void OnCollisionEnter(Collision collision)
     {
        if (collision.transform.tag == "Player")
        {
            
 

            oldCoins = PlayerPrefs.GetInt("CashPoints");
            newCoins = oldCoins + 1;
            PlayerPrefs.SetInt("CashPoints", newCoins );
            gameObject.SetActive(false);
        }

    }
}
