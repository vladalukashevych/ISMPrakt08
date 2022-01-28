using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class PlaceOfWork
    {
        public string CompanyName { set; get; }

        public Address Address; 
        public string ContactNumber { set; get; }
        public string CompanyWebsite { set; get; }

        public PlaceOfWork(string companyName, Address address, string contactNumber, string companyWebsite)
        {
            CompanyName = companyName;
            Address = new Address(address);
            ContactNumber = contactNumber;
            CompanyWebsite = companyWebsite;
        }

        public PlaceOfWork(string companyName, Address address, string contactNumber)
        {
            CompanyName = companyName;
            Address = new Address(address);
            ContactNumber = contactNumber;
            CompanyWebsite = "none";
        }

        public PlaceOfWork(PlaceOfWork placeOfWork)
        {
            CompanyName = placeOfWork.CompanyName;
            Address = placeOfWork.Address;
            ContactNumber = placeOfWork.ContactNumber;
            CompanyWebsite = placeOfWork.CompanyWebsite;
        }

        public string GetPlaceOfWorkInfo()
        {
            return $"Company name: {CompanyName}\nAddress: {Address.GetAddress()}\n Contact number: {ContactNumber}" +
                $"Company website: {CompanyWebsite}";
        }
    }
}
