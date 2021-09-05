using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canva_display : MonoBehaviour
{

    //public static float gefahreneKM;
    

    //public Text km;

    public Text demoText;

    //km anzeie
    public Text kmStandText;
    private float kmStandWert;

    //Coins / Cash Anzeie
    private int oldCoins;
    public Text coinsText;

    //gesundheitsanzeige in %
    private float gesundheitsWert;
    public Text gesundheitsText;

    //auto gang anzeige
    private int autoGang;
    public Text autoGangText;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //korrektur = 26.61446;
         //gefahreneKM = database.gefahrenekm /100;
         

         //Textfield.text = gefahreneKM + " km Gefahren"; 


        demoText.text = "ich bin die neue anzeige";


        //km anzeige
        kmStandWert = database.gefahrenekm /100;
        kmStandText.text = kmStandWert + "km";

        // cash anzeie
        oldCoins = PlayerPrefs.GetInt("CashPoints");
        coinsText.text = oldCoins + " $";

        //gesundheitsanzeite in %
        gesundheitsWert = PlayerPrefs.GetFloat("HealthPoints");
        gesundheitsText.text = gesundheitsWert + " %";

        //auto gang anzeige
        autoGang = PlayerPrefs.GetInt("AutoGang");
        autoGangText.text = autoGang + "";

    }
}
