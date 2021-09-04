using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class damageController : MonoBehaviour
{

private float oldGesundheit;
private float newGesundheit;
public float schaden = 20f;
public float naturschaden = 5f;
public float autoschaden = 6f;

private void OnCollisionEnter(Collision collision)
     {
        if (collision.transform.tag == "Damaging")
        {
            
            
            oldGesundheit = PlayerPrefs.GetFloat("HealthPoints", newGesundheit );
            newGesundheit = oldGesundheit - schaden;

            if (newGesundheit <= 0)
            {
                
                SceneManager.LoadScene("GameOver");
            }
            else
            {
            //Debug.Log("päng " + oldGesundheit + "| NewGesundheit: " + newGesundheit);
            //database.gesundheit = newGesundheit;
            PlayerPrefs.SetFloat("HealthPoints", newGesundheit );
            }

        }




         if (collision.transform.tag == "natur")
        {
            
            
            oldGesundheit = PlayerPrefs.GetFloat("HealthPoints", newGesundheit );
            newGesundheit = oldGesundheit - naturschaden;

            if (newGesundheit <= 0)
            {
                
                SceneManager.LoadScene("GameOver");
            }
            else
            {
            //Debug.Log("päng " + oldGesundheit + "| NewGesundheit: " + newGesundheit);
            //database.gesundheit = newGesundheit;
            PlayerPrefs.SetFloat("HealthPoints", newGesundheit );
            }

        }

        if (collision.transform.tag == "auto")
        {
            
            
            oldGesundheit = PlayerPrefs.GetFloat("HealthPoints", newGesundheit );
            newGesundheit = oldGesundheit - autoschaden;

            if (newGesundheit <= 0)
            {
                
                SceneManager.LoadScene("GameOver");
            }
            else
            {
            //Debug.Log("päng " + oldGesundheit + "| NewGesundheit: " + newGesundheit);
            //database.gesundheit = newGesundheit;
            PlayerPrefs.SetFloat("HealthPoints", newGesundheit );
            }

        }









     }

   
    
}
