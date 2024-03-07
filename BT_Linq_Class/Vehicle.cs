using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Linq_Class
{
    class Vehicle
    {
        public Vehicle()
        {
        }

        public String manufacturer { get; set; }
        public String name { get; set; }
        public int year { get; set; }
        public String color { get; set; }
        public decimal price { get; set; }

        public Vehicle(string manufacturer, string name, int year, string color, decimal price)
        {
            this.manufacturer = manufacturer;
            this.name = name;
            this.year = year;
            this.color = color;
            this.price = price;
        }   

        public override string ToString()
        {
            return $"{manufacturer} {name} - Year: {year} - Color: {color} - Price: {price} ";
        }
    }
}
