using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_design_pattern_simple
{
    public interface CreditCard
    {
        string GetName();
        decimal GetAmount();       

    }
    public class Platinum : CreditCard
    {
        public decimal GetAmount()
        {
            return 1000;
        }

        public string GetName()
        {
            return "Platinum";
        }
    }

    public class Gold : CreditCard
    {
        public decimal GetAmount()
        {
            return 1500;
        }

        public string GetName()
        {
            return "Gold";
        }
    }

    public class CreditCardFactory {

        public static CreditCard Create(string creditCardName) {
            CreditCard creditCard = null;
            if (creditCardName == "gold")
            {
                creditCard = new Gold(); 
            }
            else if (creditCardName == "Platinum")
            {
                creditCard = new Platinum(); 
            }
            return creditCard;
        }
    }
}
