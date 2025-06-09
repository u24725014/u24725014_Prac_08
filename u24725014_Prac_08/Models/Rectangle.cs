using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u24725014_Prac_08.Models
{
    public class Rectangle : Polygon
    {
        [Range(1, 450)]
        [Display(Name = "Breadth")]
        public int Breadth { get; set; }

        public Rectangle() { }

        public Rectangle(int length, int breadth)
        {
            Length = length;
            Breadth = breadth;
            Sides = 4;
        }

        public override string getSVG()
        {
            return $"<rect x=\"{XCoordinate}\" y=\"{YCoordinate}\" width=\"{Length}\" height=\"{Breadth}\" fill=\"{FillColour}\" stroke=\"{StrokeColour}\" stroke-width=\"{StrokeWidth}\" />";
        }

        public override double getArea()
        {
            return Length * Breadth;
        }
    }
}