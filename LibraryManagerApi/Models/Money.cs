namespace LibraryManagerApi.Models
{
    public class Money
    {
        private readonly double _value;

        public Money(double value)
        {
            _value = value;
        }

        public static Money FromPoundsAndPence(double cost)
        {
            return new Money(cost);
        }

        public override bool Equals(object obj)
        {
            return _value.Equals(((Money)obj)._value);
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }
    }
}