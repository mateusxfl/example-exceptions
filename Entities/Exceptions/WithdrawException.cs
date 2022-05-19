namespace ExampleException.Entities.Exceptions
{
    public class WithdrawException : ApplicationException
    {
        public WithdrawException(string message) : base(message) { }
    }
}