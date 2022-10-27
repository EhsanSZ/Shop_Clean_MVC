using Domain.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Builders
{
    public class AddressBuilder
    {
        private Address _address;
        public string TestCity => "Tehran";
        public string TestState => "Jeyhon";
        public string TestZipCode => "2342345";
        public string TestPostalAddress => "Ehsan Tower";


        public AddressBuilder()
        {
            _address = WithDefaultValues();
        }

        public Address Build()
        {
            return _address;
        }
        private Address WithDefaultValues()
        {
            _address = new Address(TestCity, TestState, TestZipCode, TestPostalAddress);
            return _address;
        }
    }
}
