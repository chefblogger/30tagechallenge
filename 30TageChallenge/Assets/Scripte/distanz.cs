using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distanz : MonoBehaviour
{

public float totalDistance = 0f;
public static float gefahrenekm;



 public bool record = true;
 private Vector3 previousLoc;
 void FixedUpdate() {
     if (record)
         RecordDistance ();
 }
 void RecordDistance () {
     totalDistance += Vector3.Distance(transform.position, previousLoc);
     previousLoc = transform.position;

     database.gefahrenekm = totalDistance;

 }
 void ToggleRecord() => record = !record;



}
