using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task4
{
    public class Computer
    {
        public byte Generation { get; set; }
        public string Type { get; set; }
        public short ProductYear { get; set; }
        public bool IsNew { get; set; }
        public short Price { get; set; }

        public Computer(byte generation, string type, short productyear, bool isnew, short price)
        {
            this.Generation = generation;
            this.Type = type;
            this.ProductYear = productyear;
            this.IsNew = isnew;
            this.Price = price;
        }

        public virtual void GetComputer()
        {
            Console.Write($"Generation - {Generation}\nComputer type - {Type}\nProduct of Year - {ProductYear}\nCondition - {IsNew}\nPrice - {Price}\n");
        }

    }
}
