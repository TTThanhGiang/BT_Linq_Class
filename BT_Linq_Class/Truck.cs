using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Linq_Class
{
    class Truck : Vehicle
    {
        public Truck()
        {
        }

        public Truck(string manufacturer, string name, int year, string color, decimal price, int weight, bool hasTrailer,string company) : base(manufacturer, name, year, color, price)
        {
            this.weight = weight;
            this.hasTrailer = hasTrailer;
            this.companyName = company;
        }
        public string companyName { get; set; }
        public int weight { get; set; }
        public bool hasTrailer { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"- Weight: {weight} tan - Ro-mooc: {hasTrailer} - Company: {companyName}";
        }

    }
}
