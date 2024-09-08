namespace strategy_design_pattern_sample
{
    //Strategy context
    public class StrategyNavigateContext { 
        private INavigateStrategy _navigationStrategy;
        public StrategyNavigateContext(INavigateStrategy navigationStrategy)
        {
            _navigationStrategy = navigationStrategy;
        }

        public void SetRout(INavigateStrategy navigationStrategy)
        {
            _navigationStrategy = navigationStrategy; 
        }
        public Rout GetRout(string origin, string destination)
        {
            return _navigationStrategy.Navigate(origin, destination);
        }
    }


}
