namespace factory_design_pattern_simple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string creditcardName = "gold";
            CreditCard creditCard = CreditCardFactory.Create(creditcardName);
            if (creditCard != null) {
                Console.WriteLine("Hello "+creditCard.GetName());
            }
        }
    }
}
