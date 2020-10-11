﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoWaypoint : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 25f;  // скорость движения
    [SerializeField] private GameObject[] myWaypoints;  // список точек по которым будет двигаться енеми

    private int myWaypointId = 0;                    // текущая точка в массиве куда двигаться

    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    void Waypoint1()
    {
        // если точки есть
        if (myWaypoints.Length != 0)
        {
            // если мы уже достигли назначенной точки, то переходим к следующей
            if (Vector3.Distance(myWaypoints[myWaypointId].transform.position, transform.position) <= 0)
            {
                myWaypointId++;
            }

            //если точки исчерпаны то переходим к началу массива точек
            if (myWaypointId >= myWaypoints.Length)
            {
                myWaypointId = 0;
            }

            //движемся в назначенную точку
            // move towards waypoint
            transform.position = Vector3.MoveTowards(transform.position, myWaypoints[myWaypointId].transform.position, moveSpeed * Time.deltaTime);
        }
    }
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    // Update is called once per frame
    void Update()
    {
        Waypoint1();
    }
}
