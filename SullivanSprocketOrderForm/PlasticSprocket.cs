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
    public class PlasticSprocket : Sprocket
    {
        public PlasticSprocket() : base()
        {
        }
        public PlasticSprocket(int itemID, int numItems, int numTeeth) : base(itemID, numItems, numTeeth)
        {
        }
        protected override void Calc()
        {
            Price = Convert.ToDecimal(NumItems * (NumTeeth * .02M));
        }

        public override string ToString()
        {
            return base.ToString() + " Material: Plastic";
        }
    }
}
