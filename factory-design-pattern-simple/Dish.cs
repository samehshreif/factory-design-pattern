using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_design_pattern_simple
{
    public interface IDish
    {
        void Serve();
    }

    internal class Dish
    {
        public Dish() { }
    }
}
