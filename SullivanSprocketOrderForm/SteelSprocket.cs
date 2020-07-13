//Patrik Sullivan psullivan8@cnm.edu
//SullivanSprocketOrderForm
//6-30-20

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SullivanSprocketOrderForm
{
    public class SteelSprocket : Sprocket
    {
        public SteelSprocket() : base()
        {
        }
        public SteelSprocket(int itemID, int numItems, int numTeeth) : base(itemID, numItems, numTeeth)
        {
        }

        protected override void Calc()
        {
            Price = Convert.ToDecimal(NumItems * (NumTeeth * .05M));
        }

        public override string ToString()
        {
            return base.ToString() + " Material: Steel";
        }
    }
}
