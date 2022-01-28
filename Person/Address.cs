using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Address
    {
        public string Country { set; get;}
        public string City { set; get; }
        public string Street { set; get; }
        public int HouseNumber { set; get; }
        public int Index { set; get; }

        public Address(string country, string city, string street, int houseNumber, int index)
        {
            Country = country;
            City = city;
            Street = street;
            HouseNumber = houseNumber;
            Index = index;
        }

        public Address(Address address)
        {
            Country = address.Country;
            City = address.City;
            Street = address.Street;
            HouseNumber = address.HouseNumber;
            Index = address.Index;
        }

        public string GetAddress()
        {
            return $"{Country}, {City}, {Street} Street, {HouseNumber}, {Index}";
        }
    }
}
