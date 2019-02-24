using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARRANGE
            IOrderDAO x = null;
            IClientDAO client = null;
            IClient c = new Client(client, "Hash", "9237484");
            IOrder order = new Order(x, c);
            x.SetDelivered(order);

            //ACT
            order.Deliver();
        }
    }
}
