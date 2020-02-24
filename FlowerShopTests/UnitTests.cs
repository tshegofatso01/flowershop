using NUnit.Framework;
using flowerShop;
using NSubstitute;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //arrange
            IClient c = Substitude.For<IClient>();
            IOrderDAO o = Substitude.For<IOrderDAO>();
            Order order = new Order(c, o);

            //ACT
            order.deliver();
            //Assert
            o.Recieved().setDelivered(order);
            Assert.Pass();
        }
    }
}