﻿using UnityEngine;

public class RopeCutter : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        // 0 is for Left Mouse Button
        // Listen for the user input
        if(Input.GetMouseButton(0))
        {
            // Place the ray at the point of the mouse position
            // Vector2.zero to prevent the ray from going anywhere
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Iput.mousePosition), Vector2.zero);
        }
    }
}