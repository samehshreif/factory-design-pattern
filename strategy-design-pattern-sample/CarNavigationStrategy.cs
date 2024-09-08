namespace strategy_design_pattern_sample
{
    //Strategy concretes
    public class CarNavigationStrategy : INavigateStrategy
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
