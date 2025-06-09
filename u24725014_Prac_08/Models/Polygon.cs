using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u24725014_Prac_08.Models
{

    public abstract class Polygon
    {
        [Range(0, 100)]
        public int Sides { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Fill Colour")]
        public string FillColour { get; set; }

        [Required]
        [Display(Name = "Stroke Colour")]
        public string StrokeColour { get; set; }

        [Range(1, 10)]
        [Display(Name = "Stroke Width")]
        public int StrokeWidth { get; set; }

        [Display(Name = "X Coordinate")]
        public int XCoordinate { get; set; } = 0;

        [Display(Name = "Y Coordinate")]
        public int YCoordinate { get; set; } = 0;

        [Range(1, 450)]
        [Display(Name = "Length")]
        public int Length { get; set; }

        public string getSides()
        {
            return "#Sides is " + Sides;
        }

        public abstract string getSVG();
        public abstract double getArea();
    }
}