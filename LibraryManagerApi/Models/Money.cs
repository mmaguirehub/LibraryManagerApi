namespace LibraryManagerApi.Models
{
    public class Money
    {
        private readonly decimal _value;

        public Money(decimal value)
        {
            _value = value;
        }

        public static Money FromPoundsAndPence(decimal cost)
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