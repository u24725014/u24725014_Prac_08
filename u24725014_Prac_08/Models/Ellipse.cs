using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u24725014_Prac_08.Models
{
    public class Ellipse : Polygon
    {
        [Range(1, 450)]
        [Display(Name = "Minor Axis")]
        public double MinorAxis { get; set; }

        public Ellipse() { }

        public Ellipse(double majorAxis, double minorAxis)
        {
            Sides = 0;
            Length = (int)majorAxis;
            MinorAxis = minorAxis;
            XCoordinate = 150;
            YCoordinate = 100;
        }

        public override string getSVG()
        {
            return $"<ellipse cx=\"{XCoordinate}\" cy=\"{YCoordinate}\" rx=\"{Length}\" ry=\"{MinorAxis}\" fill=\"{FillColour}\" stroke=\"{StrokeColour}\" stroke-width=\"{StrokeWidth}\" />";
        }

        public override double getArea()
        {
            return Math.Round(Math.PI * (MinorAxis / 2) * (Length / 2), 2);
        }
    }
}