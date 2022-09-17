using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    [SerializeField] private FixedJoystick joystick;
    [SerializeField] private Vector2 DebugLog;

    private void Update()
    {
        DebugLog.x = joystick.Vertical;
        DebugLog.y = joystick.Horizontal;
    }
}
