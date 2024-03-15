﻿public class Ring
{
    //private Point2D _ringCenter;
    private double _outerRadius;
    private double _innerRadius;

    public double OuterRaduis
    {
        get
        {
            return _outerRadius;
        }
        set
        {
            Validator.AssertOnPositiveValue(value);
            if (value < InnerRadius)
            {
                throw new ArgumentException();
            }
            _outerRadius = value;
        }
    }
    public double InnerRadius
    {
        get
        {
            return _innerRadius;
        }
        set
        {
            Validator.AssertOnPositiveValue(value);
            if (value > OuterRaduis)
            {
                throw new ArgumentException();
            }
            _innerRadius = value;
        }
    }

    public Point2D Center
    {
        get
        {
            return new Point2D((OuterRaduis / 2.0), (InnerRadius / 2.0));
        }
    }
    public double Area
    {
        get
        {
            return Math.PI * (Math.Pow(OuterRaduis, 2) -  Math.Pow(InnerRadius,2));
        }
    }
    public Ring()
    {
        OuterRaduis = 0;
        InnerRadius=0;
    }
    public Ring(double  outerRadius, double innerRadius)
    {
        OuterRaduis = outerRadius;
        InnerRadius = innerRadius;
    }
    }

