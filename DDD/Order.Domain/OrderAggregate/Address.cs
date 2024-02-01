using Order.Domain.Core;

namespace Order.Domain.OrderAggregate
{
    public class Address : ValueObject
    {
        public string City { get; private set; }
        public string District { get; private set; }
        protected string DetailAddress { get; private set; }


        public Address(string city, string district, string detailAddress)
        {
            //may use validations
             
            City = city;
            District = district;
            DetailAddress = detailAddress;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return City;
            yield return District;
            yield return DetailAddress;
        }
    }
}