
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment : ProcessingLite.GP21
{
    public float x1;
    public float y1;
    public float x2;
    public float y2;
    public float spaceBetweenLines = 0.2f;
    public int i;
    


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
        Ground();

        //HorizontalLine();
        //Ellipse(x1, y1, x2, y2);
        //Rect(x1, y1, x2, y2);
        Line(x1, y1, x2, y2);
        Fire();
        Woods();

    }

    public void Ground()
    {
        Stroke(0, 100, 0);
        StrokeWeight(4);
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



    //public void HorizontalLine()
    //{
    //    //Line(20.21f, 1.1f, 16.41f, 0.3f);

    //    for (int i = 0; i <= 10; i++)
    //        Line(i, 0, 10, i);

    //    if (i % 2 == 0)
    //    {
    //        Stroke(140, 23, 180);
    //    }    
                
    //    else
    //    {
    //        Stroke(255);
    //    }

    //}    

    public void Fire()
    {


        float adjustment = Mathf.Sin(Time.time % Mathf.PI * 2 - Mathf.PI); /**Time.deltaTime * 4*/

        Stroke(255, 69, 0);
        StrokeWeight(13);
        Line(18 + adjustment, 4.1f, 18.18f, 1.3f);



        Stroke(255, 0, 0);
        StrokeWeight(5);
        Line(18, 4.5f, 18.18f, 1.3f);

        Stroke(255, 69, 0);
        StrokeWeight(13);
        Line(19.3f, 3.2f, 18.55f, 1);

        Stroke(255, 69, 0);
        StrokeWeight(6);
        Line(20, 2, 19.0f, 1.3f);

        Stroke(255, 0, 0);
        StrokeWeight(3);
        Line(20.3f, 2.2f, 18.32f, 0.7f);


        Stroke(255, 0, 0);
        StrokeWeight(5);
        Line(19.37f, 3.5f, 18.55f, 1.3f);

        


        //Stroke(255, 69, 0);
        //StrokeWeight(3);
        //Rect(20.02f, 1.4f, 19.25f, 1.84f);

        //Stroke(255, 69, 0);
        //StrokeWeight(3);
        //Rect(18.3f, 3.1f, 18.88f, 1);

        //Rect(17.50f, 3.75f, 18.01f, 1.5f);

    }

    public void Woods()
    {
        Stroke(139, 69, 19);
        StrokeWeight(9);
        Line(20.67f, 1.2f, 16.6f, 0.2f);
        Stroke(139, 69, 19);
        StrokeWeight(9);
        Line(20.35f, 0.25f, 16.13f, 2.1f);

        Stroke(160, 82, 45);
        StrokeWeight(4);
        Line(16.25f, 2.2f, 20.9f, -0.4f);

        Stroke(160, 82, 45);
        StrokeWeight(4);
        Line(20.57f, 0.9f, 16.86f, 0.4f);
    }

}


        




    



    

     

