using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{

    public enum SurfaceMaterial
    {
        laminate,
        oak,
        rosewood,
        veneer,
        pine
    }
    public class Desk
    {
        public const double maxwidth = 96;
        public const double minwidth = 24;
        public const double maxdepth = 48;
        public const double mindepth = 12;
        //private const double maxdrawers = 7;
        //private const double mindrawers = 0;

        public double Width { get; set; }
        public double Depth { get; set; }
        public double NumberofDrawers { get; set; }
        public SurfaceMaterial SurfaceMaterial  { get; set; }

        public Desk(double width, double depth, double numberofdrawers,SurfaceMaterial surfaceMaterial)
        {

            Width = width;
            Depth = depth;
            NumberofDrawers = numberofdrawers;
            SurfaceMaterial = surfaceMaterial;
        }

    }
}
