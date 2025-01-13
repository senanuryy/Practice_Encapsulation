using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Encapsulation
{
    internal class Car
    {
        private int _doorCount;
        
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public int DoorCount
        {
            get
            {
                return _doorCount;
            }
            set
            {
                if (value == 2 || value == 4)
                {
                    _doorCount = value;
                }
                else
                {
                    Console.WriteLine("Invalid door count! Please provide 2 or 4.");
                    _doorCount = -1;
                }
            }
        }
         
        public void CarInfo()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("DoorCount: " + DoorCount);
        }
    }
}
