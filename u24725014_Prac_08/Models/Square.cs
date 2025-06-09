using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u24725014_Prac_08.Models
{
    public class Square : Polygon
    {
        public Square() { }

        public Square(int length)
        {
            Sides = 4;
            Length = length;
        }

        public override string getSVG()
        {
            return $"<rect x=\"{XCoordinate}\" y=\"{YCoordinate}\" width=\"{Length}\" height=\"{Length}\" fill=\"{FillColour}\" stroke=\"{StrokeColour}\" stroke-width=\"{StrokeWidth}\" />";
        }

        public override double getArea()
        {
            return Length * Length;
        }
    }
}