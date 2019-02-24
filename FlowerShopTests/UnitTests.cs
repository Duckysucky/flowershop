using NUnit.Framework;
using FlowerShop;
using NSubstitute;

namespace Tests
{
    public class Tests
    {
        private IOrderDAO x;
        private IClientDAO client;
        private IClient c;
        private IOrder order;
    [SetUp]
        public void Setup()
        {
            x = Substitute.For<IOrderDAO>();
            client = Substitute.For<IClientDAO>();
            c = Substitute.For<IClient>();
            order = Substitute.For<IOrder>();

        }

        [Test]
        public void Test1()
        {
            
            
            //ARRANGE
            Order test = new Order(x, c);
            //ACT 
            test.Deliver();
            //ASSERT
            Assert.AreEqual(1, x.ReceivedCalls());
        }
    }
}