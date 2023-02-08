global using System;
global using System.Numerics;

namespace Rotation_Algo;

/*
    This algo gives the rotation by getting the two points in the co_ordinate system
    
    Make sure to give the origin co_ordinates of the place from where the angle is to made between
    the origin_co and the target_co.


    Caution...

    If you find any trouble so may it due to the quadrant arrangment as it different frameworks the position of the x and y axis is diferent as well as their
    origin,
    so if you find any problem just move to the rotation class and configure the quadrant as per your need

    If facing any other problem then do let us know....
*/

public class RA
{
    public static void Main(string[] args)
    {
        Console.Clear();
        /*
            practical use of the rotation algo
        */
        Rotation rot = new Rotation();

        Vector2 origin_co = new Vector2(-10,-10);
        Vector2 target_co = new Vector2(20,20);
        float rotation = rot.GetRotation(origin_co,target_co);
        System.Console.WriteLine(rotation);

    }

}
