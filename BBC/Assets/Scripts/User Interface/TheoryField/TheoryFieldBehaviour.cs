﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheoryFieldBehaviour : MonoBehaviour
{
    public Vector3 TurnOnPosition;
    public Vector3 TurnOffPosition;

    void Start()
    {
        TurnOnPosition = gameObject.transform.position;
        TurnOffPosition = new Vector3(-12, -1013, 0);
        gameObject.transform.position = TurnOffPosition;
    }
}
