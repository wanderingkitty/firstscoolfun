using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment3 : ProcessingLite.GP21
{
    
    public Vector2 circlePosition;
    Vector2 velocity;
    float  maxSpeed = 10;
    //public Vector2 direction;
    //float diameter = 1f;



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
            velocity = Vector2.zero;

        }

        if (Input.GetMouseButton(0))
        {
            Line(circlePosition.x, circlePosition.y, MouseX, MouseY);
        }

        if (Input.GetMouseButtonUp(0))
        {
            //velocity = new Vector2(MouseX, MouseY) - circlePosition;
            velocity.x = MouseX - circlePosition.x;
            velocity.y = MouseY - circlePosition.y;
        }
        if (velocity.magnitude > maxSpeed)
        {
            velocity.Normalize();
            velocity *= maxSpeed;
        }

        circlePosition += velocity * Time.deltaTime;

        Bounce();

    }

    private void Bounce()
    {
        if (circlePosition.x > Width || circlePosition.x < 0)
        {
            velocity.x *= -1;
        }

        if (circlePosition.y > Height || circlePosition.y < 0)
        {
            velocity.y *= -1;
        }
    }
}
