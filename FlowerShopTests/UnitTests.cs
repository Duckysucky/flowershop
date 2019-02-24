using NUnit.Framework;
using FlowerShop;
using NSubstitute;
using System;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        private IOrderDAO x;
        private IClientDAO client;
        private IClient c;
        private IOrder order;
        private List<Flower> flowers;
        private IFlower Flower;
        [SetUp]
        public void Setup()
        {
            x = Substitute.For<IOrderDAO>();
            client = Substitute.For<IClientDAO>();
            c = Substitute.For<IClient>();
            order = Substitute.For<IOrder>();
            Flower = Substitute.For<IFlower>();
            flowers = Substitute.For<List<Flower>>();

        }

        [Test]
        public void Test1()
        {
            
            
            //ARRANGE
            Order test = new Order(x, c);

            //ACT 
            double total = test.Price;
            //ASSERT
            Assert.That(total > 0);
        }
    }
}