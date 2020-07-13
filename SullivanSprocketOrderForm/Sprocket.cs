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
    public abstract class Sprocket
    {
        private int numItems;
        private int numTeeth;
        public Sprocket() : this(-1, 1, 1)
        {
        }
        public Sprocket(int itemID, int numItems, int numTeeth)
        {
            ItemID = itemID;
            this.numItems = numItems;
            this.numTeeth = numTeeth;
            Calc();
        }
        public int ItemID { get; set; }
        public int NumItems
        {
            get { return numItems; }
            set { numItems = value; Calc(); }
        }
        public int NumTeeth
        {
            get { return numTeeth; }
            set { numTeeth = value; Calc(); }
        }
        public decimal Price { get; protected set; }
        protected abstract void Calc();
        public override string ToString()
        {
            return "Order: " + ItemID + " Number of Items: " + NumItems + " Teeth: " + NumTeeth + " Price: " + Price.ToString("C");
        }
    }
}
