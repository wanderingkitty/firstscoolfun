using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment3 : ProcessingLite.GP21
{
    
    public Vector2 circlePosition;
    public float diameter = 2;
    public Vector2 direction;
    

    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        Background(0);
        circlePosition.x = MouseX;
        circlePosition.y = MouseY;
        
        

        if (Input.GetMouseButtonDown(0))
        {
            circlePosition.x = MouseX;
            circlePosition.y = MouseY;
        }

        if (Input.GetMouseButton(0))
        {
            Line(circlePosition.x, circlePosition.y, MouseX, MouseY);
        }

        else
        {

            Circle(circlePosition.x, circlePosition.y, diameter);
            direction = new Vector2(MouseX - circlePosition.x, MouseY - circlePosition.y);
            

        }
    }









    



}
