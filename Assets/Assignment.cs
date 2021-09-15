using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment : ProcessingLite.GP21
{
    public float x1;
    public float y1;
    public float x2;
    public float y2;
    
    
    // Start is called before the first frame update
    void Start()
    {

    }




    // Update is called once per frame
    void Update()
    {

        

        Background(Color.black);
        LetterA();
        LetterL();
        LetterI();
        LetterN();
        LetterA();
        LetterS();
        Draw();
        Line(x1, y1, x2, y2);
        //Ellipse(x1, y1, x2, y2);
        

    }

    public void Draw()
    {
        Stroke(107, 142, 45);
        StrokeWeight(2.5f);
        Line(0.15f, 0.15f, 21, 0.15f);
    }

    

    public void LetterA()
    {
        Stroke(255, 255, 255);
        StrokeWeight(2);
        Line(1, 5, 0.25f, 1);
        Line(4, 1, 3, 5);
        Line(3, 5, 1, 5);
        Line(3.44f, 3.39f, 0.72f, 3.39f);

        Line(11.9f, 1, 12.72f, 4.38f);
        Line(14.04f, 4.32f, 12.7f, 4.33f);
        Line(14.02f, 4.3f, 14.9f, 1);
        Line(12.38f, 3, 14.4f, 3);
    }

    public void LetterL()

    {
        Stroke(255, 255, 255);
        StrokeWeight(2);
        Line(5.16f, 1.01f, 5.15f, 5.04f);
        Line(5.15f, 1.04f, 8, 1.05f);
    }

    public void LetterI()
    {
        Stroke(169, 169, 169);
        StrokeWeight(8);
        Line(9, 5.62f, 9, 0.27f);
        
        //Line(9, 5, 9, 5.05f);
    }

    public void LetterN()
    {
        Stroke(255, 255, 255);
        StrokeWeight(2);
        Line(10, 4, 10, 1);
        Line(11, 1, 10, 4);
        Line(11, 4, 11, 1);

    }

    public void LetterS()
    {
        Stroke(218, 165, 32);
        StrokeWeight(7);
        Line(6.36f, 5.60f, 11.57f, 5.60f);
        Line(6.48f, 4.29f, 6.49f, 5.25f);
        Line(11.4f, 4.29f, 11.4f, 5.25f);
        Line(7.71f, 7.95f, 10.22f, 7.96f);

        Stroke(40, 79, 79);
        Line(9, 7.65f, 9, 5.92f);
    }    
    
    

}
