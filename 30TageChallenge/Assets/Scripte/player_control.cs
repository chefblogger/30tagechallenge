using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_control : MonoBehaviour
{

public float movementSpeed = 10.0f;
public float rotationSpeed = 200.0f;




    // Update is called once per frame
    void Update()
    {
       Computer(); 
       //Handy();
    }

        void Handy()
    {
    transform.Rotate(0, UltimateJoystick.GetHorizontalAxis( "movement" ) * Time.deltaTime * rotationSpeed, 0);
    transform.Translate(0,0, UltimateJoystick.GetVerticalAxis( "movement" ) * Time.deltaTime * movementSpeed);  
    }

    void Computer()
    {
    transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
    transform.Translate(0,0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed); 
    }

}
