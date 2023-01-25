using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.bl
{
    public class Medicine
    {
        private string name;
        private string type;
        private double price;
        private int quantity;
        private int threshold;
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Threshold { get => threshold; set => threshold = value; }

        public Medicine(string name, string type, double price, int quantity, int threshold)
        {
            Name = name;
            Type = type;
            Price = price;
            Quantity = quantity;
            Threshold = threshold;
        }

        public Medicine(string name, int quantity)
        {
            this.Name = name;
            this.Quantity = quantity;
        }
    }
}
