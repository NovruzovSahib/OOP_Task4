using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task4
{
    public class Lenovo : HP
    {
        public Lenovo(byte generation, string type, short productyear, bool isnew, short price, string model) : base(generation, type, productyear, isnew, price, model)
        {
        }
    }
}
