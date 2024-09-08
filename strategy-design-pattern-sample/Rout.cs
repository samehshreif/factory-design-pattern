namespace strategy_design_pattern_sample
{
    public class Rout {
        public string origin { get; set; }
        public string destination { get; set; }
        public override string ToString()
        {
            return $"Origin: {origin} , Destination: {destination}";
        }
    }


}
