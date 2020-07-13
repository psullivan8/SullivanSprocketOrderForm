//Patrik Sullivan psullivan8@cnm.edu
//SullivanSprocketOrderForm
//6-30-20

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SullivanSprocketOrderForm
{
    public class AluminumSprocket : Sprocket
    {
        public AluminumSprocket() : base()
        {
        }
        public AluminumSprocket(int itemID, int numItems, int numTeeth) : base(itemID, numItems, numTeeth)
        {
        }

        protected override void Calc()
        {
            Price = Convert.ToDecimal(NumItems * (NumTeeth * .04M));
        }

        public override string ToString()
        {
            return base.ToString() + " Material: Aluminum";
        }
    }
}
