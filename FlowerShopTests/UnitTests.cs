using NUnit.Framework;
using FlowerShop;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            //ARRANGE
            IOrderDAO x;
            IClientDAO client;
            IClient c = new Client(client, "Hash", "9237484");
            IOrder order = new Order(x, c);

            //ACT
            order.Deliver();
        }

        [Test]
        public void Test1()
        {
            //ASSERT
            Assert.Pass();
        }
    }
}