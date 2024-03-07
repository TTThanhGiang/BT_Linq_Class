using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Linq_Class
{
    class Car : Vehicle
    {
        public Car()
        {
        }

        public Car(string manufacturer, string model, int year, string color, decimal price, int numberOfSeats, bool isgasoLineCar) : base(manufacturer,model, year, color, price)
        {
            this.numberOfSeats = numberOfSeats;
            this.isgasoLineCar = isgasoLineCar;
        }

        public int numberOfSeats { get; set; }
        public bool isgasoLineCar { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"- NumSeats: {numberOfSeats} - Gasoline fuel: {isgasoLineCar}";
        }
    }
}
