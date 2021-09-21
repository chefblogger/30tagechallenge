using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class database : MonoBehaviour
{

public static float gesundheit = 100;

public static float gefahrenekm = 0;

public static float punkte = 0;

void Start(){
    PlayerPrefs.SetInt("LevelCoins", 0 );
}

}
