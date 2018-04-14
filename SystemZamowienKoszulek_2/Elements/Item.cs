using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemZamowienKoszulek_2.Elements
{
    public class Item
    {
        public int Id { get; set; }
        private static int _counter = 1000000;
        public Type Type { get; set; }
        public Size Size { get; set; }
        public Name Name { get; set; }
        public double Price { get; set; }


        public Item(Type type, Size size, Name name, double price)
        {
            Id = _counter++;
            Type = type;
            Size = size;
            Name = name;
            Price = price;
        }

        public Item()
        {
            Id = 9999999;
            Name = Name.Koszulka;
        }

    }
}
