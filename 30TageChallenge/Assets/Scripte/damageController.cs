using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class damageController : MonoBehaviour
{

private float oldGesundheit;
private float newGesundheit;
public float schaden = 5f;

private void OnCollisionEnter(Collision collision)
     {
        if (collision.transform.tag == "Damaging")
        {
            
            
            oldGesundheit = database.gesundheit;
            newGesundheit = oldGesundheit - schaden;

            if (newGesundheit <= 0)
            {
                
                SceneManager.LoadScene("GameOver");
            }
            else
            {
            //Debug.Log("päng " + oldGesundheit + "| NewGesundheit: " + newGesundheit);
            database.gesundheit = newGesundheit;
            }

        }
     }
        
    
}
