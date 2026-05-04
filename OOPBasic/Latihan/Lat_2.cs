using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic.Latihan
{
    public class Lat_2
    {
        public static void main()
        {
            ShoppingCart cart = new ShoppingCart();

            cart.addItem("Laptop", 999);
            cart.addItem("Mouse", 25);
            Console.WriteLine("Total: " + cart.getTotal());

            Console.WriteLine("Applying discount code: " + cart.applyDiscountCode("SAVE10"));
            Console.WriteLine("Total after discount: " + cart.getTotal());

            Console.WriteLine("Applying discount code: " + cart.applyDiscountCode("SAVE10"));
            
            cart.checkout();
            cart.addItem("Keyboard", 50);
            Console.WriteLine("Total after checkout: " + cart.getTotal());
        }
    }

    class ShoppingCart
    {
        private Dictionary<string, decimal> items;
        private bool isCheckedOut;
        private string codeDiscount;

        public ShoppingCart() 
        {
            this.items = new Dictionary<string, decimal>();
            this.isCheckedOut = false;
            this.codeDiscount = string.Empty;
        }

        public string CodeDiscount
        {
            get { return codeDiscount; }
        }

        public bool applyDiscountCode(string code)
        {
            if (code == "SAVE10" && string.IsNullOrEmpty(this.codeDiscount))
            {
                this.codeDiscount = code;
                return true;

            }
            
            if (!string.IsNullOrEmpty(this.codeDiscount))
            {
                return false;
            }

            return false;
        }

        public void addItem(string productName, decimal price)
        {
            try
            {
                if (!this.isCheckedOut)
                {
                    this.items.Add(productName, price);
                }
                else
                {
                    throw new InvalidOperationException("Cannot add items after checkout.");
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error adding item: " + ex.Message);
            }
        }

        public decimal getTotal()
        {
            decimal sum = 0;
            decimal discount = 0;

            foreach (var item in this.items)
            {
                sum += item.Value;
            }

            if (!string.IsNullOrEmpty(this.codeDiscount))
            {
                discount = sum * 0.1m;
            }

            return sum - discount;
        }

        public bool checkout()
        {
            this.isCheckedOut = true;
            
            return this.isCheckedOut;
        }
    }
}
