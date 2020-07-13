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
    public class SprocketOrder
    {
        public SprocketOrder(string customerName, Address address, List<Sprocket> items)
        {

            CustomerName = customerName;
            Address = address;
            this.items = items;
        }

        public SprocketOrder() : this("TBD", null, new List<Sprocket>())
        {

        }
        private List<Sprocket> items;

        public string CustomerName { get; set; }

        public Address Address { get; set; }

        public decimal TotalPrice { get; private set; }

        public List<Sprocket> Items
        {
            get { return items; }
            set { items = value; Calc(); }
        }

        public void Add(Sprocket item)
        {
            items.Add(item);
            Calc();
        }

        public void Remove(Sprocket item)
        {
            items.Remove(item);
            Calc();
        }

        public void Calc()
        {
            TotalPrice = 0;
            foreach (var item in items)
            {
                TotalPrice += item.Price;
            }
        }

        public override string ToString()
        {
            string orderResults = "";
            orderResults += CustomerName + ": " + items.Count;
            if(items.Count > 1)
            {
                orderResults += " items.";
            }
            else
            {
                orderResults += " item.";
            }
            orderResults += "\nTotal Price: " + TotalPrice.ToString("C");
            if (Address != null)
            {
                orderResults += "\nShip to:\n" + Address;
            }
            else
            {
                orderResults += "\nLocal Pickup";
            }
            return orderResults;
        }
    }
}
