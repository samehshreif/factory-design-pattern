namespace strategy_design_pattern_sample
{
    public class WalkNavigationStrategy : INavigateStrategy
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
