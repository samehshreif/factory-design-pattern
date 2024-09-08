namespace strategy_design_pattern_sample
{
    public class BusNavigationStrategy : INavigateStrategy
    {
        public Rout Navigate(string origin, string destination)
        {
            return new Rout
            {
                origin = origin,
                destination = destination
            };
        }
    }


}
