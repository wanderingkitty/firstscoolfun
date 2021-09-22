using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment3 : ProcessingLite.GP21
{
    
    public Vector2 circlePosition;
    //float diameter = 1f;
    //public Vector2 direction;
    

    
    // Start is called before the first frame update
    void Start()
    {
        circlePosition = new Vector2(Width / 2, Height / 2); 
    }
    // Update is called once per frame
    void Update()
    {
        Background(0);
        Circle(circlePosition.x, circlePosition.y, 1);

        if (Input.GetMouseButtonDown(0))
        {
            circlePosition.x = MouseX;
            circlePosition.y = MouseY;
        } 
            




    }









    



}
