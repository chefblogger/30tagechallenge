using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canva_display : MonoBehaviour
{

    public static float gefahreneKM;
    

    public Text Textfield;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //korrektur = 26.61446;
         gefahreneKM = database.gefahrenekm /100;
         

         Textfield.text = gefahreneKM + " km Gefahren"; 
    }
}
