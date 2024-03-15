﻿static public class CollisionManager
{
    static public bool isCollision(Rectangle rectangle1, Rectangle rectangle2)
    {
        double differenceX = Math.Abs(rectangle1.Center.CoordinateX - rectangle2.Center.CoordinateX);
        double halfLatitude = Math.Abs(rectangle1.Width + rectangle2.Width) / 2;
        double differenceY = Math.Abs(rectangle1.Center.CoordinateY - rectangle2.Center.CoordinateY);
        double halfLength = Math.Abs(rectangle1.Length + rectangle2.Length) / 2;
        return differenceX < halfLatitude && differenceY < halfLength;
    }
    static public bool isCollision(Ring ring1,Ring ring2)
    {
        double hypotenuse = Math.Sqrt(Math.Pow(Math.Abs(ring1.Center.CoordinateX - ring2.Center.CoordinateX), 2) + Math.Pow(Math.Abs(ring1.Center.CoordinateY - ring2.Center.CoordinateY), 2));
        double sumOfOuterlRadii = ring1.OuterRaduis + ring2.OuterRaduis;
        return hypotenuse < sumOfOuterlRadii;
    }
}

