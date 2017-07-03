using System;

public class Size
{
    private double width, height;

    public Size(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public static Size GetRotatedSize(Size size, double angleOfRotation)
    {
        double absoluteCosOfAngle = Math.Abs(Math.Cos(angleOfRotation));
        double absoluteSinOfAngle = Math.Abs(Math.Sin(angleOfRotation));
        double newWidth = (absoluteCosOfAngle * size.width) + (absoluteSinOfAngle * size.height);
        double newHeight = (absoluteSinOfAngle * size.width) + (absoluteCosOfAngle * size.height);

        return new Size(newWidth, newHeight);
    }
}
