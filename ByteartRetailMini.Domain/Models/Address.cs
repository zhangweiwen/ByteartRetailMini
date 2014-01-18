namespace ByteartRetailMini.Domain.Models
{
    public class Address
    {
        public static readonly Address Emtpy = new Address();

        public virtual string Zip { get; set; }

        public virtual string City { get; set; }

        public virtual string State { get; set; }

        public virtual string Street { get; set; }

        public virtual string Country { get; set; }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Country != null ? Country.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (State != null ? State.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (City != null ? City.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Street != null ? Street.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Zip != null ? Zip.GetHashCode() : 0);
                return hashCode;
            }
        }

        protected bool Equals(Address other)
        {
            return string.Equals(Country, other.Country) &&
                string.Equals(State, other.State) &&
                string.Equals(City, other.City) &&
                string.Equals(Street, other.Street) &&
                string.Equals(Zip, other.Zip);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) 
                return false;

            if (ReferenceEquals(this, obj)) 
                return true;

            if (obj.GetType() != GetType()) 
                return false;

            return Equals((Address) obj);
        }
    }
}