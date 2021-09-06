using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gartenzaun_collider : MonoBehaviour
{


private void OnCollisionEnter(Collision collision)
    {

            if (collision.transform.tag == "Player")
                    {
                        
                        
                        
                            gameObject.SetActive(false);
                    

                    }


                }
}
