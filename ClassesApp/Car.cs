using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Car
    {
       //private string _model = "";
        private string _brand = "";
        public static int NumberOfCars = 0;
        //private bool _isLuxury;
        public Car(string model, string brand, bool isLuxury)
        {
            NumberOfCars++;
            Model = model;
            Brand = brand;
            Console.WriteLine("An object of car model " + Model + " and brand " + Brand + " has been created!");
            IsLuxury = isLuxury;
        }

        public string Brand { get
            {
                if (IsLuxury)
                {
                    return _brand + " (Luxury)";
                }
                else
                {
                    return _brand;
                } 
            }
            set {
            if(string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Brand cannot be empty. Setting to default value.");
                    _brand = "DefaultValue";
                }
            else
                {
                    _brand = value;
                }
                    
        } }
        public string Model { get; set; }
        public bool IsLuxury { get; set; }
        public void drive()
        {
            Console.WriteLine($"The car {Brand} {Model} is driving.");
        }
    }
}
