using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class DeskQuote
    {

        public Desk Desk { get; set; }
        public string Name { get; set; }
        public string OrderDate { get; set; }
        public double RushOrder {  get; set; }

        public double Depth { get { return Desk.Depth; } }
        public double Width { get{ return Desk.Width; } }
        public double NumberofDrawers { get { return Desk.NumberofDrawers; } }
        public SurfaceMaterial SurfaceMaterial { get { return Desk.SurfaceMaterial; } }


        public double RushCost = 0;
        public double surfaceArea = 0;
        public double totalSurfaceArea = 0;
        public double addDrawer = 0;

        private const double BasePrice = 200;
        private const double PriceDrawer = 50;
        private const double PriceOak = 200;
        private const double PriceLaminate = 100;
        private const double PriceRosewood = 300;
        private const double PriceVeneer = 125;
        private const double PricePine = 50;
        private const double ExtraSurfaceArea = 1;
        private const double RushSmall3 = 60;
        private const double RushMed3 = 70;
        private const double RushLarge3 = 80;
        private const double RushSmall5 = 40;
        private const double RushMed5 = 50;
        private const double RushLarge5 = 60;
        private const double RushSmall7 = 30;
        private const double RushMed7 = 35;
        private const double RushLarge7 = 40;
        //private const double StandardProc = 14;

        //bool IsRushOrder;
        
        public DeskQuote(Desk desk) 
        {
            Desk = desk;
            GetOrderDate();
        }

        public void GetOrderDate()
        {
            DateTime dateTime = DateTime.Now;
            OrderDate = dateTime.ToString("MM/dd/yyyy");
        }


        //GetPrice Function
        public double GetPrice()
        {
            double deskPrice = 0;
            surfaceArea = Width * Depth;
            GetRush();


            if (surfaceArea>1000)
            {
                totalSurfaceArea = (surfaceArea - 1000) * ExtraSurfaceArea + BasePrice; 
            }
            else
                { totalSurfaceArea = BasePrice; }
            
            if (NumberofDrawers>0)
            {
                addDrawer = NumberofDrawers * PriceDrawer;
            }
            else
            { addDrawer = 0; }

            switch (SurfaceMaterial)
            {
                case SurfaceMaterial.oak:
                    {
                        GetRush();
                        deskPrice = totalSurfaceArea + addDrawer + RushCost + PriceOak;
                        break;
                    }
                case SurfaceMaterial.laminate:
                    {
                        GetRush();
                        deskPrice = totalSurfaceArea + addDrawer + RushCost + PriceLaminate;
                        break;
                    }
                case SurfaceMaterial.rosewood:
                    {
                        GetRush();
                        deskPrice = totalSurfaceArea + addDrawer + RushCost + PriceRosewood;
                        break;
                    }
                case SurfaceMaterial.veneer:
                    {
                        GetRush();
                        deskPrice = totalSurfaceArea + addDrawer + RushCost + PriceVeneer;
                        break;
                    }
                case SurfaceMaterial.pine:
                    {
                        GetRush();
                        deskPrice = totalSurfaceArea + addDrawer + RushCost + PricePine;
                        break;
                    }
            }
            return deskPrice;
        }





        public double GetRush()
        {
            switch (RushOrder)
            {
                case 3:
                    if (totalSurfaceArea < 1000)
                    { RushCost = RushSmall3; }

                    else if (totalSurfaceArea > 1000 && totalSurfaceArea < 2000)
                    { RushCost = RushMed3; }
                    else
                    { RushCost = RushLarge3; }
                    return RushCost;
                        
                case 5:
                    if (totalSurfaceArea < 1000)
                    { RushCost = RushSmall5; }

                    else if (totalSurfaceArea > 1000 && totalSurfaceArea < 2000)
                    { RushCost = RushMed5; }
                    else
                    { RushCost = RushLarge5; }
                    return RushCost;
                        
                case 7:
                    if (totalSurfaceArea < 1000)
                    { RushCost = RushSmall7; }

                    else if (totalSurfaceArea > 1000 && totalSurfaceArea < 2000)
                    { RushCost = RushMed7; }
                    else
                    { RushCost = RushLarge7; }
                    return RushCost;
                default:
                    return RushCost;
            }
        }
    }
}
