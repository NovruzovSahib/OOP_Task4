using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task4
{
    public class Asus : Computer
    {
        public string Model { get; set; }
        public Asus(byte generation, string type, short productyear, bool isnew, short price, string model) : base(generation, type, productyear, isnew, price)
        {
            Model = model;
        }
        public override void GetComputer()
        {
            Console.WriteLine($"Model - {Model}");
            base.GetComputer();
            Console.WriteLine();
        }
    }
}
