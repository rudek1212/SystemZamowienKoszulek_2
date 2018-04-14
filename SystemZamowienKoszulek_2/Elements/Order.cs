namespace SystemZamowienKoszulek_2.Elements
{
    public class Order
    {
        private static int _counter = 1000000;


        public Order(Cart cart, int customerId)
        {
            Cart = cart;
            CustomerId = customerId;
            OrderId = _counter++;
            State = State.Payment;
        }

        public Order()
        {
            CustomerId = 9999999;
            Cart = new Cart(9999999);
            State = State.Payment;
            OrderId = _counter++;
        }

        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public State State { get; set; }
        public Cart Cart { get; set; }

        public bool AddProduct(Item item)
        {
            if (State != State.Payment) return false;
            Cart.AddItemToCart(item);
            return true;
        }

        public bool RemoveProduct(int id)
        {
            if (State != State.Payment) return false;
            Cart.RemoveItemFromCart(id);
            return true;
        }


    }
}