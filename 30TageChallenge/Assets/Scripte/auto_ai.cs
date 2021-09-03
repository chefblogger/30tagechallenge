using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auto_ai : MonoBehaviour
{

 public List<Transform> waypoints = new List<Transform>();
 private Transform targetWaypoint;
 private int targetWaypointIndex = 0;
 private float minDistance = 0.1f;
 private int lastWaypointIndex; 

 public float movementSpeed = 25f;
 public float rotationSpeed = 25f;


    

     void Start()
    {
        
        lastWaypointIndex = waypoints.Count - 1;
        targetWaypoint = waypoints[targetWaypointIndex];    

        
    }

   


     void Update() {

         Vector3 directionToTarget = targetWaypoint.position - transform.position;
         Quaternion rotationToTarget = Quaternion.LookRotation(directionToTarget);

         transform.rotation = Quaternion.Slerp(transform.rotation, rotationToTarget, rotationSpeed * Time.deltaTime);

         Debug.DrawRay(transform.position, transform.forward * 50f, Color.green, 0f);
        Debug.DrawRay(transform.position, directionToTarget, Color.red, 0f);

         float distance = Vector3.Distance(transform.position, targetWaypoint.position);
        //Debug.Log("Distance: " + distance);
        CheckDistanceToWaypoint(distance);

        transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, movementSpeed * Time.deltaTime);

        



        
    }


    void CheckDistanceToWaypoint(float currentDistance){
            if(currentDistance <= minDistance)
            {
                targetWaypointIndex++;
                UpdateTargetWaypoint();
            }
    }

    void UpdateTargetWaypoint(){

        if(targetWaypointIndex > lastWaypointIndex)
            {
                targetWaypointIndex = 0;
            }

        targetWaypoint = waypoints[targetWaypointIndex];
    }



}