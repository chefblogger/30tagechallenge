using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    
    public Image healthBar;
    
    private float oldGesundheit;

    


    void Update()
    {
        oldGesundheit = PlayerPrefs.GetFloat("HealthPoints");
        //oldGesundheit = database.gesundheit;
        healthBar.fillAmount = oldGesundheit /100;
    }


}
