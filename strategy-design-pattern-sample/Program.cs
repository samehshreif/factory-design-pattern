using System.Threading.Channels;

namespace strategy_design_pattern_sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StrategyNavigateContext context= new StrategyNavigateContext(new BusNavigationStrategy());
            while (true)
            {
                Console.WriteLine("insert from 1:3");
                var switch_on = Console.ReadLine();
                switch (switch_on)
                {
                    case "1":
                        context.SetRout(new BusNavigationStrategy());
                        break;
                    case "2":
                        context.SetRout(new WalkNavigationStrategy());  
                        break;
                    case "3":
                        context.SetRout(new CarNavigationStrategy());  
                        break;

                    default:
                        break;
                }
                Console.WriteLine(context.GetRout("from", "to"));
            }

        }
    } 
}
