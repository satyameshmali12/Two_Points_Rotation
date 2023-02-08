using System;

namespace Rotation_Algo;

public class Rotation
{


    /// <summary>
    /// <para>Gives the rotation with respect to the origin_cordinates and the target_cordinated</para>
    ///</summary>
    public float GetRotation(Vector2 origin_cordinates, Vector2 target_cordinates)
    {

        // configuring the target_cordinates to get it's position when measure from the 0,0 (origin)
        Vector2 updated_tc = target_cordinates - origin_cordinates;
        Vector2 abs_updated_tc = new Vector2(Math.Abs(updated_tc.X), Math.Abs(updated_tc.Y));

        /*

        Explanation

              .t
            . .
           .  .
          .   .
       o ...... 
       o :- origin_co_ordiantes
       t :- target_co_ordinates

       if we draw a traingle between the two point their will three angles and in this three one will 90 which will can be this elimated from our calculation
       thus,

       let our origin_angle be A, and other be B
       thus,
         A+B+90 = 180
         A+B = 90
       
       It means that our orgin angle will range between 0-90
       After several observation we found the relation between the angle the distance of the co_ordinates,
       i.e,
       angle of origin depends on the distance of the origin from the target y point
       whereas other angle depends on the distance of the origin from the target x point

       Thus after taking their ratios and dividing it by the remaining angle we found the per angle power,
        which on multiplying with the ratios we get the angle as show below

       At last,according to the quadrant as per given point with respect to the origin is incremented to the origin_angle;

       Make sure to change the quadrant setting in the last if you feel it wrong with yours framwork axis arrangement.
       The quadrant settings in this are with respect to the Godod.
        */



        // finding ratios
        float x_p = abs_updated_tc.Y / abs_updated_tc.X;
        float y_p = abs_updated_tc.X / abs_updated_tc.Y;

        float per_p = 90 / (x_p + y_p);

        float increment = 0;

        /*
        Getting the increment as per the quadrant in which the point lies with respect to the target point as that of the origin_cordinates
        */
        if (updated_tc.X < 0)
        {
            if (updated_tc.Y < 0)
            {
                increment = 90;
            }
            else if (updated_tc.Y > 0)
            {
                increment = 180;
            }
        }
        else if (updated_tc.X > 0 && updated_tc.Y > 0)
        {
            increment = 270;
        }


        return (x_p * per_p) + increment;
    }

}