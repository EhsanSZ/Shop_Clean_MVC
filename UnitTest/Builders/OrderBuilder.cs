using Domain.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Builders
{
    public class OrderBuilder
    {
        private Order _order;
        public string TestBuyerId => "58968";
        public int TestCatalogItemId => 234;
        public string TestProductName => "Test Product Name";
        public string TestPictureUri => "https://Test.net/test.jpg";
        public int TestUnitPrice = 1000;
        public int TestUnits = 3;


        public Order CreateOrderWithDefaultValues()
        {

            List<OrderItem> testOrderItem = new List<OrderItem>()
            {
                 new OrderItem(TestCatalogItemId,TestProductName,TestPictureUri,TestUnitPrice,TestUnits),
            };
            return new Order(TestBuyerId, new AddressBuilder().Build(), testOrderItem, PaymentMethod.OnlinePaymnt, null);
        }
    }
}
