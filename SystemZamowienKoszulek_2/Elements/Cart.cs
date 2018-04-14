using System;
using System.Collections.Generic;
using System.Linq;

namespace SystemZamowienKoszulek_2.Elements
{
    public class Cart
    {
        public List<Item> List = new List<Item>();

        public Cart(int id)
        {
            CustomerId = id;
        }

        public int CustomerId { get; set; }

        public Item AddItemToCart(Item item)
        {
            List.Add(item);
            return List[List.Count - 1];
        }

        public Item RemoveItemFromCart(int id)
        {
            var tmp = new Item();
            for (var i = List.Count; i > 0; i--)
            {
                if (List.ElementAt(i - 1).Id != id) continue;
                tmp = List.ElementAt(i - 1);
                List.RemoveAt(i - 1);
            }
            return tmp;
        }

        public Dictionary<Name, int> ReturnNameAndAmount()
        {
            var tmp = new Dictionary<Name, int>();

            foreach (Name type in Enum.GetValues(typeof(Name)))
            {
                tmp.Add(type, 0);
                foreach (var element in List)
                    if (element.Name == type)
                        tmp[type]++;
            }
            return tmp;
        }
    }
}