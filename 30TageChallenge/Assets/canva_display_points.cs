using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canva_display_points : MonoBehaviour
{

    private float newPoints;
    
    public Text punkte;

    // Update is called once per frame
    void Update()
    {
        
         newPoints = database.punkte;
         

         //Textfield2.text = newPoints;; 
    }
}
