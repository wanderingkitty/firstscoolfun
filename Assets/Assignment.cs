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
        Line(x1, y1, x2, y2);
      
        
     
    }
 public void LetterA()
    {
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
        Line(5.16f, 1.01f, 5.15f, 5.04f);
        Line(5.15f, 1.04f, 8, 1.05f);
    }

    public void LetterI()
    {
        Line(9, 1, 9, 4);
        Line(9, 5, 9, 5.05f);
    }

    public void LetterN()
    {
        Line(10, 4, 10, 1);
        Line(11, 1, 10, 4);
        Line(11, 4, 11, 1);

    }

    
}
