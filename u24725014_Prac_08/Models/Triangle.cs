using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u24725014_Prac_08.Models
{
    public class Triangle : Polygon
    {
        [Range(1, 450)]
        public int Height { get; set; }

        public Triangle() { }

        public Triangle(int baseLength, int height)
        {
            Sides = 3;
            Length = baseLength;
            Height = height;
            XCoordinate = 10;
            YCoordinate = 10;
        }

        public override string getSVG()
        {
            int x1 = XCoordinate;
            int y1 = YCoordinate + Height;
            int x2 = XCoordinate + (Length / 2);
            int y2 = YCoordinate;
            int x3 = XCoordinate + Length;
            int y3 = YCoordinate + Height;

            return $"<polygon points=\"{x1},{y1} {x2},{y2} {x3},{y3}\" fill=\"{FillColour}\" stroke=\"{StrokeColour}\" stroke-width=\"{StrokeWidth}\" />";
        }

        public override double getArea()
        {
            return 0.5 * Length * Height;
        }
    }
}