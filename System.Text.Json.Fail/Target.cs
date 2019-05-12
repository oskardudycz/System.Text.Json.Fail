using System;
using System.Collections.Generic;

using Baseline;

namespace Marten.Testing
{
    public enum Colors
    {
        Red,
        Blue,
        Green
    }

    public class Target
    {
        public Target()
        {
            Id = Guid.NewGuid();
            StringDict = new Dictionary<string, string>();
        }

        public Guid Id { get; set; }

        public int Number { get; set; }
        public long Long { get; set; }
        public string String { get; set; }
        public string AnotherString { get; set; }

        public Guid OtherGuid { get; set; }

        public Target Inner { get; set; }

        public Colors Color { get; set; }

        public bool Flag { get; set; }

        public string StringField;

        public double Double { get; set; }
        public decimal Decimal { get; set; }
        public DateTime Date { get; set; }
        public DateTimeOffset DateOffset { get; set; }

        public float Float;

        public int[] NumberArray { get; set; }

        public string[] TagsArray { get; set; }

        public HashSet<string> TagsHashSet { get; set; }

        public Target[] Children { get; set; }

        public int? NullableNumber { get; set; }
        public DateTime? NullableDateTime { get; set; }
        public bool? NullableBoolean { get; set; }
        public Colors? NullableColor { get; set; }

        public IDictionary<string, string> StringDict { get; set; }

        public Guid UserId { get; set; }
    }

    public class Address
    {
        public Address()
        {
        }

        public Address(string text)
        {
            var parts = text.ToDelimitedArray();
            Address1 = parts[0];
            City = parts[1];
            StateOrProvince = parts[2];
        }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string StateOrProvince { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }

        public bool Primary { get; set; }
    }
}