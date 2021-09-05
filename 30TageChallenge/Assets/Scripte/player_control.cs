using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_control : MonoBehaviour
{

public float movementSpeed = 10.0f;
public float rotationSpeed = 200.0f;

private int DBAutoGang;
public int AutoGang;



    // Update is called once per frame
    void Update()
    {
        Schaltung();


       Computer(); 
       //Handy();

       Quit();
    }

        void Handy()
    {
   // transform.Rotate(0, UltimateJoystick.GetHorizontalAxis( "movement" ) * Time.deltaTime * rotationSpeed, 0);
   // transform.Translate(0,0, UltimateJoystick.GetVerticalAxis( "movement" ) * Time.deltaTime * movementSpeed);  
    }

    void Computer()
    {
    transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
    transform.Translate(0,0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed); 
    }


    void Schaltung(){

        DBAutoGang = PlayerPrefs.GetInt("AutoGang");

        if (Input.GetKeyDown("space"))
        {
            if (DBAutoGang <= 3)
                    {
                    movementSpeed += 10f;
                    AutoGang = DBAutoGang + 1;
                    PlayerPrefs.SetInt("AutoGang", AutoGang );
                    }
             
            
            

        }
        if (Input.GetKeyDown("e"))
        {

            if (DBAutoGang >= 1)
                    {
                    movementSpeed -= 10f;
                    AutoGang = DBAutoGang - 1;
                    PlayerPrefs.SetInt("AutoGang", AutoGang );
                    }

        }
    }



    void Quit(){
        if (Input.GetKey("q"))
        {
            Application.Quit();
        }
    }

}
